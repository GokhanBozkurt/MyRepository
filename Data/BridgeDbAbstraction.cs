using System.Data;
using System.Data.Common;
using System.Data.OracleClient;

namespace Safiye.Data
{


    interface IBridgeDbImplementor
    {
        DbConnection Connection { get; set; }
        void Init(string connStr);
        bool Open();
        bool Close();
        DataTable FillTable(string commandText, DbParameter[] dbParameters);
        DataTable FillTable(string commandText, OracleParameterCollection dbParameters);
    }
 

    abstract  class BridgeDbAbstraction
    {
        protected  IBridgeDbImplementor DbImplementor;

        protected BridgeDbAbstraction(IBridgeDbImplementor dbImplementor)
        {
            DbImplementor = dbImplementor;
        }
        public abstract void Init(string connStr);
        public abstract bool Open();
        public abstract bool Close();
        public abstract DataTable FillTable(string commandText, OracleParameter[] dbParameters);
        public abstract DataTable FillTable(string commandText, OracleParameterCollection dbParameters);
    }

    class BridgeRefinedDbAbstractionImpl : BridgeDbAbstraction
    {
        public BridgeRefinedDbAbstractionImpl(IBridgeDbImplementor dbImplementor) : base(dbImplementor)
        {
        }
        public override void Init(string connStr)
        {
            DbImplementor.Init(connStr);
        }
        public override bool Open()
        {
            return DbImplementor.Open();
        }

        public override bool Close()
        {
            return DbImplementor.Close();
        }

        public override DataTable FillTable(string commandText, OracleParameter[] dbParameters)
        {
            return DbImplementor.FillTable(commandText, dbParameters);
        }

        public override DataTable FillTable(string commandText, OracleParameterCollection dbParameters)
        {
            return DbImplementor.FillTable(commandText, dbParameters);
        }
    }


    class BridgeOracleImplementor : IBridgeDbImplementor
    {
        public DbConnection Connection { get; set; }

        public void Init(string connStr)
        {
            Connection = new OracleConnection(connStr);
        }

        public bool Open()
        {
            Connection.Open();
            return true;
        }

        public bool Close()
        {
            Connection.Close();
            return true;
        }

        public DataTable FillTable(string commandText, DbParameter[] dbParameters)
        {
            var command=new OracleCommand(commandText, (OracleConnection) Connection);
            command.CommandType=CommandType.Text;
            for (int i = 0; i < dbParameters.Length; i++)
            {
                if (dbParameters[i] != null)
                {
                    command.Parameters.Add(dbParameters[i]);
                }
            }
            if (dbParameters.Length>0)
            {
            }
            var da = new OracleDataAdapter(command);
            var ds = new DataSet("MyDataSet");
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable FillTable(string commandText, OracleParameterCollection dbParameters)
        {
            var command = new OracleCommand(commandText, (OracleConnection)Connection);
            foreach (OracleParameter oracleParameter in dbParameters)
            {
                command.Parameters.Add(oracleParameter);
            }
            var da = new OracleDataAdapter(command);
            var ds = new DataSet("MyDataSet");
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}

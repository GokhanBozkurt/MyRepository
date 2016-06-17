using System.Data;
using System.Data.OracleClient;

namespace Safiye.Data
{
    public class OracleRepository
    {
        private readonly BridgeDbAbstraction _repository ;
        public OracleRepository(string connStr)
        {
            _repository = new BridgeRefinedDbAbstractionImpl(new BridgeOracleImplementor());
            _repository.Init(connStr);
            _repository.Open();
        }

        public DataTable FillTable(string commandText, OracleParameter[] dbParameters)
        {
            return  _repository.FillTable(commandText, dbParameters);
        }

        public DataTable FillTable(string commandText, OracleParameterCollection dbParameters)
        {
            return _repository.FillTable(commandText, dbParameters);
        }

        public bool Close()
        {
            return _repository.Close();
        }
    }
}
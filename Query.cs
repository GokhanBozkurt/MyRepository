namespace Safiye
{
    public static class Query
    {
        public static string SqlMerchant = @" select * from    POSMRC.MRC_ONLINE_INFO P where 1=1 AND P.MRC_NO =:PI_MRC_NO ";
        public static string SqlCard = @" select * from CARD.CARD_INFO WHERE CARD_NO = : PI_CARD_NO ";
        public static string SqlCardProd = @" select * from CARD.CARD_MAIN_INFO WHERE CARD_NO = : PI_CARD_NO ";
        public static string SqlBank = @" select * from CARD.BANK_INFO WHERE CODE= :PI_BANK_NO ";
        public static string SqlMrcSeqNo = @" select * from POSMRC.MRC_SEQ_REL P WHERE  P.MRC_NO=: PI_MRC_NO ";
        public static string SqlPosTrnxDetail = @" 
                                            select * 
                                            from    POSMRC.POS_TRNX_DETAIL_INFO 
                                            where 
                                                    F37= :F37  
                                                    and PROCESS_DATE= :PROCESS_DATE
                                                    AND TRNX_TYPE= :TRNX_TYPE 
                                    ";
        public static string SqlPcode = @" 
                                            select DISTINCT
                                                    case    WHEN C.TYPE='P' THEN 'Satış'
                                                    WHEN C.TYPE='V' THEN 'İptal'
                                                     WHEN C.TYPE='F'  THEN ' İade'
                                                     WHEN C.TYPE='O'  THEN ' İade iptal'
                                                     WHEN C.TYPE='Y'  THEN ' Sistem'
                                                     WHEN C.TYPE='I'  THEN  'Sorgu'
                                                    END İŞLEM,
                                                    C.*,
                                                    P.* 
                                            from    POSMRC.POS_PCODE_TRNX_REL P
                                                    INNER JOIN CARD.TRNX_INFO C ON P.TRNX_CODE=C.CODE AND C.SUB_CODE = P.TRNX_SUB_CODE 
                                            WHERE 
                                                    PCODE=:PI_PCODE 
                                 ";

        public static string SqlTerminal = @" SELECT * FROM  POSMRC.POS_INFO P where 1=1 AND P.TERM_ID =:PI_TERM_ID  ";
        public static string SqlSelectProcess = @" SELECT  
                                                            distinct
                                                                    SUB.* 
                                                                    ,T.DSCR
                                                                    ,
                                                                    RT.DSCR HATA ,
                                                                    RT.PRINTER_MSG ,
                                                            case    WHEN T.TYPE='P' THEN 'Satış'
                                                            WHEN T.TYPE='V' THEN 'İptal'
                                                             WHEN T.TYPE='F'  THEN ' İade'
                                                             WHEN T.TYPE='O'  THEN ' İade iptal'
                                                             WHEN T.TYPE='Y'  THEN ' Sistem'
                                                             WHEN T.TYPE='I'  THEN  'Sorgu'
                                                            END İŞLEM
                                                    FROM ( 
                                                            SELECT 'INFO' SRC_TBL,P.F39 KART_CEVAP,  P.TERM_ID, P.F42 MRC_NO, P.F2 CARDNO, P.F4 TUTAR, P.PROCESS_DATE, P.F37 RRN,P.F3, P.INT_RES_CODE,P.TRNX_TYPE, P.TRNX_CODE, P.TRNX_SUB_CODE, P.MSG_TYPE, P.SOURCE, P.SOURCE_FUI, P.ERROR_MSG, P.BATCH_NO, P.SYS_ENTRY_DATE, P.SYS_ENTRY_TIME, P.F49 CURRENCY, P.SEQUENCE_NO, P.ISS_BANK_CODE, P.ORDER_ID, P.BATCH_NO BATCHNO,P.DEST, P.DEST_FUI,P.POS_GUID   FROM POSMRC.POS_TRNX_INFO P 
                                                            UNION ALL
                                                            SELECT 'DECL' SRC_TBL,P.F39 KART_CEVAP,  P.TERM_ID, P.F42 MRC_NO, P.F2 CARDNO, P.F4 TUTAR, P.PROCESS_DATE, P.F37 RRN,P.F3, P.INT_RES_CODE,P.TRNX_TYPE, P.TRNX_CODE, P.TRNX_SUB_CODE, P.MSG_TYPE, P.SOURCE, P.SOURCE_FUI, P.ERROR_MSG, P.BATCH_NO, P.SYS_ENTRY_DATE, P.SYS_ENTRY_TIME, P.F49 CURRENCY, P.SEQUENCE_NO, P.ISS_BANK_CODE, P.ORDER_ID, P.BATCH_NO BATCHNO,P.DEST, P.DEST_FUI,P.POS_GUID   FROM POSMRC.POS_TRNX_DECLINED_INFO P 
                                                             UNION ALL
                                                            SELECT 'HOLD' SRC_TBL,P.F39 KART_CEVAP,  P.TERM_ID, P.F42 MRC_NO, P.F2 CARDNO, P.F4 TUTAR, P.PROCESS_DATE, P.F37 RRN,P.F3, P.INT_RES_CODE,P.TRNX_TYPE, P.TRNX_CODE, P.TRNX_SUB_CODE, P.MSG_TYPE, P.SOURCE, P.SOURCE_FUI, P.ERROR_MSG, P.BATCH_NO, P.SYS_ENTRY_DATE, P.SYS_ENTRY_TIME, P.F49 CURRENCY, P.SEQUENCE_NO, P.ISS_BANK_CODE, P.ORDER_ID, P.BATCH_NO BATCHNO,P.DEST, P.DEST_FUI,P.POS_GUID   FROM POSMRC.POS_TRNX_HOLD_INFO P
                                                         ) SUB   LEFT JOIN CARD.TRNX_INFO T ON T.CODE=SUB.TRNX_CODE AND T.SUB_CODE = SUB.TRNX_SUB_CODE
                                                    LEFT JOIN CARD.INT_RET_CODES_INFO RT ON RT.RET_CODE=SUB.INT_RES_CODE  
                                                    WHERE 1=1 
                                                            AND ROWNUM <=50
                                                            AND SUB.PROCESS_DATE = :PI_DATE ";

        public static string SqlSelectMgmnt = @" 
                                                SELECT * FROM 
                                                (       SELECT 
                                                            'MGMNNT' SRC_TBL,
                                                         F3,
                                                         TERM_ID,
                                                         MRC_NO,
                                                         PROCESS_DATE,
                                                         F37 RRN,
                                                         F39 KART_CEVAP,
                                                         INT_RES_CODE,
                                                         TRNX_CODE,
                                                         TRNX_SUB_CODE,
                                                         MSG_TYPE,
                                                         SOURCE_FUI,
                                                         BATCH_NO,
                                                         SYS_ENTRY_DATE,
                                                         SYS_ENTRY_TIME,
                                                         SEQUENCE_NO,
                                                         BATCH_NO BATCHNO ,
                                                         POS_GUID
                                                        FROM    POSMRC.POS_TRNX_MNGMNT_INFO
                                            ) SUB 
                                            WHERE  ROWNUM <=50 
                                            AND SUB.PROCESS_DATE = :PI_DATE ";

        public static string SqlSelectApc = @" 
                                                SELECT 
                                                        AMOUNT, APC_GUID, AUTH_LAST_RECEIVE_DATE, AUTH_LAST_SEND_DATE, 
                                                        AUTH_TRY_CNT, BATCH_NO, BILL_NO, CARD_NO, COMPANY_CODE, 
                                                        CURR_CODE, CVV2, EXPIRE_DATE, FILE_TYPE,  
                                                        INSTALL_CNT, IN_FILE_NAME, LAST_PAYMENT_DATE, MRC_NO, 
                                                        MSG_TYPE, ONLINE_BATCH_IND, ORDER_UNIQUE_ID, ORIG_RRN, 
                                                        ORIG_STAN, OVERDRAFT_USE, PROCESSING_CODE, PROCESS_DATE, 
                                                        PROCESS_TIME, RESP_AUTH_CODE, RESP_CODE, RESP_ERROR_MSG, 
                                                        RESP_RRN, RESP_STAN, REV_LAST_RECEIVE_DATE, REV_LAST_SEND_DATE, 
                                                        REV_TRY_CNT, SEQ_NO, STATUS, SUBSCRIBER_NO, TERM_ID, TOD, 
                                                        TRNX_TERM_TYPE, TRNX_TYPE
                                                FROM POSMRC.APC_TRNX
                                                WHERE  
                                                       ROWNUM <=50 
                                                        AND PROCESS_DATE = :PI_DATE ";

        public static string SqlApcReportBillBatch = @" 
                                                    SELECT 
                                                         RR.IN_FILE_NAME ,
                                                         FR.OUT_FILE_NAME,
                                                         FR.OT_FILE_END_DATE,
                                                         RR.STATUS,
                                                         COUNT (DISTINCT ORDER_UNIQUE_ID) COUNT,
                                                         MIN (RR.AUTH_LAST_SEND_DATE) MIN_AUTH_LAST_SEND_DATE,
                                                         MAX (RR.AUTH_LAST_RECEIVE_DATE) MAX_AUTH_LAST_RECEIVE_DATE,
                                                         SUM (RR.AUTH_TRY_CNT) AUTH_TRY_CNT,
                                                         SUM (RR.REV_TRY_CNT) REV_TRY_CNT,
                                                         ROUND (FLOOR ((  MAX (RR.AUTH_LAST_RECEIVE_DATE)- MIN (RR.AUTH_LAST_RECEIVE_DATE))
                                                                 * 24
                                                                 * 60
                                                                 * 60)
                                                            / 60,
                                                            2)
                                                            PROCESS_DURATION
                                                    FROM    POSMRC.APC_TRNX RR
                                                         INNER JOIN
                                                            POSMRC.APC_FILE_TRNX FR
                                                         ON RR.IN_FILE_NAME = FR.IN_FILE_NAME
                                                   WHERE     RR.FILE_TYPE = 'FAT'
                                                         AND RR.PROCESS_DATE = :PI_DATE
                                                         AND RR.ONLINE_BATCH_IND = 'B'
                                                GROUP BY RR.IN_FILE_NAME, FR.OUT_FILE_NAME, RR.STATUS ,FR.OT_FILE_END_DATE
                                                ORDER BY MIN_AUTH_LAST_SEND_DATE DESC  ";
        public static string SqlApcReportBillDetailBatch = @" 
                                                    SELECT 
                                                         RR.IN_FILE_NAME ,
                                                         FR.OUT_FILE_NAME,
                                                         FR.OT_FILE_END_DATE,
                                                         RR.STATUS,
                                                         RR.RESP_CODE,
                                                         COUNT (DISTINCT ORDER_UNIQUE_ID) COUNT,
                                                         MIN (RR.AUTH_LAST_SEND_DATE) MIN_AUTH_LAST_SEND_DATE,
                                                         MAX (RR.AUTH_LAST_RECEIVE_DATE) MAX_AUTH_LAST_RECEIVE_DATE,
                                                         SUM (RR.AUTH_TRY_CNT) AUTH_TRY_CNT,
                                                         SUM (RR.REV_TRY_CNT) REV_TRY_CNT,
                                                         ROUND (FLOOR ((  MAX (RR.AUTH_LAST_RECEIVE_DATE)- MIN (RR.AUTH_LAST_RECEIVE_DATE))
                                                                 * 24
                                                                 * 60
                                                                 * 60)
                                                            / 60,
                                                            2)
                                                            PROCESS_DURATION
                                                    FROM    POSMRC.APC_TRNX RR
                                                         INNER JOIN
                                                            POSMRC.APC_FILE_TRNX FR
                                                         ON RR.IN_FILE_NAME = FR.IN_FILE_NAME
                                                   WHERE     RR.FILE_TYPE = 'FAT'
                                                         AND RR.PROCESS_DATE = :PI_DATE
                                                         AND RR.ONLINE_BATCH_IND = 'B'
                                                GROUP BY RR.IN_FILE_NAME, FR.OUT_FILE_NAME, RR.STATUS,RR.RESP_CODE,FR.OT_FILE_END_DATE
                                                ORDER BY MIN_AUTH_LAST_SEND_DATE DESC  ";
        public static string SqlApcReportBillOnline = @" 
                                                            SELECT 
                                                                    STATUS,
                                                                    RESP_CODE,
                                                                    MSG_TYPE,
                                                                    COUNT (DISTINCT ORDER_UNIQUE_ID) COUNT,
                                                                    MIN (RR.AUTH_LAST_SEND_DATE) MIN_AUTH_LAST_SEND_DATE,
                                                                    MAX (RR.AUTH_LAST_RECEIVE_DATE) MAX_AUTH_LAST_RECEIVE_DATE,
                                                                    SUM (RR.AUTH_TRY_CNT) AUTH_TRY_CNT,
                                                                    SUM (RR.REV_TRY_CNT) REV_TRY_CNT
                                                            FROM POSMRC.APC_TRNX RR
                                                            WHERE     FILE_TYPE = 'FAT'
                                                                    AND RR.PROCESS_DATE =  :PI_DATE
                                                                    AND RR.ONLINE_BATCH_IND = 'O'
                                                        GROUP BY 
                                                                    IN_FILE_NAME,
                                                                    STATUS,
                                                                    MSG_TYPE,
                                                                    RR.RESP_CODE
                                                        ORDER BY MAX_AUTH_LAST_RECEIVE_DATE
                                                    ";
        public static string SqlApcReportBillOnlineDetail = @" 
                                                            SELECT 
                                                                    STATUS,
                                                                    RESP_CODE,
                                                                    MSG_TYPE,
                                                                    RR.RESP_ERROR_MSG,
                                                                    RR.RESP_CODE,
                                                                    COUNT (DISTINCT ORDER_UNIQUE_ID) COUNT,
                                                                    MIN (RR.AUTH_LAST_SEND_DATE) MIN_AUTH_LAST_SEND_DATE,
                                                                    MAX (RR.AUTH_LAST_RECEIVE_DATE) MAX_AUTH_LAST_RECEIVE_DATE,
                                                                    SUM (RR.AUTH_TRY_CNT) AUTH_TRY_CNT,
                                                                    SUM (RR.REV_TRY_CNT) REV_TRY_CNT
                                                            FROM POSMRC.APC_TRNX RR
                                                            WHERE     FILE_TYPE = 'FAT'
                                                                    AND RR.PROCESS_DATE =  :PI_DATE
                                                                    AND RR.ONLINE_BATCH_IND = 'O'
                                                        GROUP BY 
                                                                    IN_FILE_NAME,
                                                                    STATUS,
                                                                    RESP_CODE,
                                                                    MSG_TYPE,
                                                                    RR.RESP_ERROR_MSG,
                                                                    RR.RESP_CODE
                                                        ORDER BY MAX_AUTH_LAST_RECEIVE_DATE
                                                    ";
        public static string SqlPosTrnxInfo = @"

                SELECT 
                      *
                    FROM posmrc.pos_trnx_info
                    WHERE     F37= :F37  
                    and PROCESS_DATE= :PROCESS_DATE
                    AND TRNX_TYPE= :TRNX_TYPE 
        ";

        public static string SqlPosTrnxDeclinedInfo = @"

                SELECT 
                      *
                    FROM posmrc.POS_TRNX_DECLINED_INFO
                    WHERE     F37= :F37  
                    and PROCESS_DATE= :PROCESS_DATE
                    AND TRNX_TYPE= :TRNX_TYPE 
 
        ";
        public static string SqlPosTrnxHoldInfo = @"

                SELECT 
                      *
                    FROM posmrc.POS_TRNX_HOLD_INFO
                    WHERE     F37= :F37  
                    and PROCESS_DATE= :PROCESS_DATE
                    AND TRNX_TYPE= :TRNX_TYPE 

        ";
        public static string SqlPosTrnxMngmntInfo = @"

                SELECT 
                      *
                    FROM posmrc.POS_TRNX_MNGMNT_INFO
                    WHERE     F37= :F37  
                    and PROCESS_DATE= :PROCESS_DATE
        ";
        public static string SqlLog = @"
                                       SELECT *
                                        FROM (SELECT 'SRD_LOG' Modul,
                                                     process_date,
                                                     f37,
                                                     MOD_UI,
                                                     SOURCE,
                                                     SOURCE_FUI,
                                                     DEST,
                                                     DEST_FUI,
                                                     MTI,
                                                     F39,
                                                     '' INT_RESP_CODE,
                                                     SYS_ENTRY_DATE,
                                                     SYS_ENTRY_TIME,
                                                     SYS_EXIT_DATE,
                                                     SYS_EXIT_TIME,
                                                     '' POS_GUID,
                                                     '' MSG_CONTENT
                                                FROM SWITCH.SRD_LOG S
                                              UNION ALL
                                              SELECT 'SRI_LOG' Modul,
                                                     process_date,
                                                     f37,
                                                     MOD_UI,
                                                     SOURCE,
                                                     '' SOURCE_FUI,
                                                     DEST,
                                                     '' DEST_FUI,
                                                     MSG_TYPE MTI,
                                                     F39,
                                                     '' INT_RESP_CODE,
                                                     SYS_ENTRY_DATE,
                                                     SYS_ENTRY_TIME,
                                                     SYS_EXIT_DATE,
                                                     SYS_EXIT_TIME,
                                                     POS_GUID,
                                                     S.MSG_CONTENT
                                                FROM POSMRC.SRI_LOG S
                                              UNION ALL
                                              SELECT 'SOBE_LOG' Modul,
                                                     process_date,
                                                     f37,
                                                     MOD_UI,
                                                     SOURCE,
                                                     SOURCE_FUI,
                                                     DEST,
                                                     DEST_FUI,
                                                     MTI,
                                                     F39,
                                                     INT_RESP_CODE,
                                                     SYS_ENTRY_DATE,
                                                     SYS_ENTRY_TIME,
                                                     SYS_EXIT_DATE,
                                                     SYS_EXIT_TIME,
                                                     '' POS_GUID,
                                                     '' MSG_CONTENT
                                                FROM SWITCH.SOBE_LOG S) SUB
                                       WHERE process_date = :PI_DATE ";


        public static string SqlSurum1 = @" 
                                        SELECT * FROM (
                                            SELECT COUNT(*) Cnt,  ISS_BANK_CODE FROM POSMRC.POS_TRNX_INFO 
                                            WHERE PROCESS_DATE = :PI_DATE
                                            AND MSG_TYPE = '0400'
                                            AND TERM_TYPE <>'VP'
                                            AND SYS_ENTRY_TIME > :PI_SYS_ENTRY_TIME
                                            GROUP BY ISS_BANK_CODE
                                        )SUB                              
                                        WHERE 1=1

                                        ";

        public static string SqlSurum2 = @"
                                             SELECT *
                                            FROM (  SELECT 'POS_TRNX_INFO' Tablee,
                                                            P.F39,
                                                            SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                            COUNT (*) Cnt
                                                        FROM POSMRC.POS_TRNX_INFO P
                                                        WHERE     PROCESS_DATE = :PI_DATE
                                                            AND SYS_ENTRY_TIME > :PI_SYS_ENTRY_TIME
                                                    GROUP BY P.F39, SUBSTR (SOURCE_FUI, 5, 1)
                                                    UNION ALL
                                                    SELECT 'POS_TRNX_MNGMNT_INFO' Tablee,
                                                            P.F39,
                                                            SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                            COUNT (*) Cnt
                                                        FROM POSMRC.POS_TRNX_MNGMNT_INFO P
                                                        WHERE     PROCESS_DATE = :PI_DATE
                                                            AND SYS_ENTRY_TIME > :PI_SYS_ENTRY_TIME
                                                    GROUP BY P.F39, SUBSTR (SOURCE_FUI, 5, 1)
                                                    UNION ALL
                                                    SELECT 'POS_TRNX_HOLD_INFO' Tablee,
                                                            P.F39,
                                                            SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                            COUNT (*) Cnt
                                                        FROM POSMRC.POS_TRNX_HOLD_INFO P
                                                        WHERE     PROCESS_DATE = :PI_DATE
                                                            AND SYS_ENTRY_TIME > :PI_SYS_ENTRY_TIME
                                                    GROUP BY P.F39, SUBSTR (SOURCE_FUI, 5, 1)) 
                                                WHERE 1=1
                                        


                                        ";
        public static string SqlSurum3 = @"
                                            SELECT * FROM 
                                            (
                                               SELECT   INT_RES_CODE,
                                                        P.F39,
                                                        SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                        COUNT (*) CNT
                                                FROM    POSMRC.POS_TRNX_DECLINED_INFO P
                                                WHERE   PROCESS_DATE = :PI_DATE
                                                        AND SYS_ENTRY_TIME > :PI_SYS_ENTRY_TIME
                                                GROUP BY P.F39, INT_RES_CODE, SUBSTR (SOURCE_FUI, 5, 1) 
                                                ) SUB
                                                 WHERE 1=1

                                        ";
        public static string SqlSurum4 = @"
                                            SELECT * FROM 
                                            (
                                               SELECT 
                                                        'TOPLAM',
                                                        SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                        COUNT(*) CNT 
                                                FROM    POSMRC.POS_TRNX_INFO 
                                                WHERE   PROCESS_DATE= :PI_DATE
                                                        AND SYS_ENTRY_TIME<:PI_SYS_ENTRY_TIME
                                                GROUP BY 
                                                        SUBSTR (SOURCE_FUI, 5, 1)
                                                UNION ALL
                                                SELECT  
                                                        DECODE ( SOURCE, 'O', 'ONUS', 'NOTONUS') COL,
                                                        SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                        COUNT(*)
                                                FROM    POSMRC.POS_TRNX_INFO 
                                                WHERE   PROCESS_DATE= :PI_DATE
                                                        AND SYS_ENTRY_TIME<:PI_SYS_ENTRY_TIME
                                                GROUP BY 
                                                        DECODE ( SOURCE, 'O', 'ONUS', 'NOTONUS'),
                                                        SUBSTR (SOURCE_FUI, 5, 1)
                                                UNION ALL

                                                SELECT 'REVERSAL',
                                                        SUBSTR (SOURCE_FUI, 5, 1) SET_NO,
                                                        COUNT(*) 
                                                FROM    POSMRC.POS_TRNX_INFO 
                                                WHERE 
                                                        PROCESS_DATE= :PI_DATE
                                                        AND MSG_TYPE=400
                                                        AND SYS_ENTRY_TIME<:PI_SYS_ENTRY_TIME  
                                                GROUP BY 
                                                        SUBSTR (SOURCE_FUI, 5, 1)
                                                ) SUB
                                                 WHERE 1=1

                                        ";
    }
}

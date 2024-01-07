namespace SAPAPI;

public class SAPServerConnection{
    public dynamic ConnectToSAP(){
        SAPbobsCOM.Company company=new SAPbobsCOM.Company();
        try{
            company.CompanyDB="192.168.1.2";
            company.Server="SAPSRV";
            company.LicenseServer="";
            // company.SLDServer ="";
            company.DbUserName="sa";
            company.DbPassword="1234";
            company.UserName="manager";
            company.DbServerType=SAPbobsCOM.BoDataServerTypes.dst_MSSQL;
            company.UseTrusted=true;
            int ret = company.Connect();
            string error=company.GetLastErrorDescription();
            int errorNo= company.GetLastErrorCode();
            if(errorNo!=0){
                Console.WriteLine(error);
            }else{
                Console.WriteLine("succesfuly connected ...!");
            }
        }catch(Exception error){
            Console.WriteLine(error.ToString());
        }
        return new {};
    }
}
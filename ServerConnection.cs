using SAPbobsCOM;

namespace SAPAPI;

public class SAPServerConnection{
    public dynamic ConnectToSAP(){
        Company company=new Company();
        try{
            company.Server="SAPSRV";
            company.CompanyDB="XYZ_LIVE";
            // company.LicenseServer="";
            // company.DbUserName="sa";
            company.UserName="manager";
            company.DbPassword="1234";
            company.DbServerType=BoDataServerTypes.dst_MSSQL2012;
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
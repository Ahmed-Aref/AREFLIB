using System;
using System.Collections.Generic;
using System.Text;

namespace AREFLIB.Functions
{
    class Queries
    {

        //Give Stores that in Saudi arabia
        public static string KSA_Stores = @" SELECT STR.Store_Number,STR.Store_Name,STR.Store_IP,STR.Region_ID,
                                             STR.Store_Lat,STR.Store_Long,STR.Meraki_Serial 
                                             FROM Store as STR
                                             WHERE Region_ID in (1,2,3,4,5,10) and STR.Store_Active = 1 ORDER BY Store_Number";


        // Stores in All Regions All Contry
        public static string All_Stores = @" SELECT STR.Store_Number,STR.Store_Name,STR.Store_IP,STR.Region_ID,
                                             STR.Store_Lat,STR.Store_Long,STR.Meraki_Serial 
                                             FROM Store as STR
                                             WHERE ISNUMERIC(STR.Store_Number) <> 0 and  STR.Store_Active = 1 ORDER BY Store_Number";

        // Give Region
        public static string Regions = @"   SELECT Region_ID,Region_Name FROM Region";

        // Give Passwords and Hashes
        public static string Emp_Password = @"   SELECT EMP_Password,Emp_Desc FROM Emp_Password ORDER BY Emp_Order";

        // Give Employee Class
        public static string Emp_Class = @"   SELECT Emp_Class,Emp_Desc FROM Emp_Class ORDER BY Emp_Order";

        // Give Employee Position
        public static string Emp_Position = @"   SELECT Emp_position,Emp_Desc FROM Emp_position ORDER BY Emp_Order";

        // Get Employee Info.
        public static string Emp_Info = @"  select EM.Employee_Code As 'ID', EM.First_Name as 'First Name', EM.Last_Name as 'Last Name',
                                                SC.English_Text_Description AS 'Status', PS.Position as 'Position',SEC.Security_Class_Description as 'Class',EM.Telephone,
                                                EM.Added 'Added_Date',EM.PasswordLastChanged 'PassLastChange'

                                                from Employee EM

                                                left outer join Employee_Status_Codes SC
                                                on SC.Employee_Status_Code = Em.Status_Code

                                                left outer join Position PS
                                                on PS.Position_Code = EM.Position_Applied_For

                                                left outer join Employee_Class EC
                                                on EC.Employee_Code COLLATE SQL_Latin1_General_CP1_CI_AS = EM.Employee_Code COLLATE SQL_Latin1_General_CP1_CI_AS

                                                left outer join Security_Class SEC
                                                on SEC.Security_Class_Code COLLATE SQL_Latin1_General_CP1_CI_AS =  EC.Security_Class_Code COLLATE SQL_Latin1_General_CP1_CI_AS

                                                order by EM.Employee_Code";

    }
}


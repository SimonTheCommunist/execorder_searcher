using MySql.Data.MySqlClient;

namespace history{
    class History{
        
        public static void Main(){
            start();
        }
        public static void start(){
            System.Console.WriteLine("Do you want to search for all presidents or a specific one?\nType 'yes' for all presidents or 'no' for a specific one");
            string pressmethod = System.Console.ReadLine().ToLower();
            if(pressmethod == "no"){
                notall();
            }else if(pressmethod == "yes"){
                allpresidents();
            }else{
                System.Console.WriteLine("ERROR CODE A000");
            }
        }
        public static void notall(){
            System.Console.WriteLine("Your choices of presidents to choose from are 'Trump', 'Clinton', 'Bush, and 'Obama'\nEnter the last name of the president with the first leter capitalized: ");
            string chosenpres = System.Console.ReadLine().ToLower();
            if(chosenpres == "trump" || chosenpres == "donald trump"){
                trump();
            }else if(chosenpres == "clinton" || chosenpres == "bill clinton"){
                bill();
            }else if(chosenpres == "bush" || chosenpres == "george bush"){
                bush();
            }else if(chosenpres == "obama" || chosenpres == "barrack obama"){
                obama();
            }else{
                System.Console.WriteLine("ERROR CODE A001");
            }
        }
        //ALL PRESIDENTS
        public static void allpresidents(){
            System.Console.WriteLine("The methods you can search by are 'Citation number','Title' and 'signing date'\nType 'cite' to search by citiation number, 'title' to search by title, and 'date' to search by siging date.\nEnter method: ");
            string srchmethod = System.Console.ReadLine().ToLower();
            if(srchmethod == "cite"){
                allcite();
            }else if(srchmethod == "date"){
                alldate();
            }else if(srchmethod == "title"){
                alltitle();
            }else{
                System.Console.WriteLine("ERROR CODE B000");
            }
        }
        public static void allcite(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM allOrd WHERE citenum LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);
                    x = 2;
                }    
            }
        }
        public static void alldate(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
               string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM allOrd WHERE date LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);
                    x = 2;
                }  
            }
        }
        public static void alltitle(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM allOrd WHERE title LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }  
            }
        }
        
        
        
        
        
        //not all presidents 
        //TRUMP-----------------------
        public static void trump(){
            System.Console.WriteLine("The methods you can search by are 'Citation number','Title' and 'signing date'\nType 'cite' to search by citiation number, 'title' to search by title, and 'date' to search by siging date.\nEnter method: ");
            string srchmethod = System.Console.ReadLine().ToLower();
            if(srchmethod == "cite"){
                trumpcite();
            }else if(srchmethod == "date"){
                trumpdate();
            }else if(srchmethod == "title"){
                trumptitle();
            }else{
                System.Console.WriteLine("ERROR CODE B000");
            }
        }
        public static void trumpcite(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Trump WHERE citenum LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }  
            }
        }
        public static void trumpdate(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Trump WHERE date LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }
            }      
        }
        public static void trumptitle(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Trump WHERE title LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                                      
                    x = 2;
                }  
            }        
        }
        //BUSH---------------------------
        public static void bush(){
            System.Console.WriteLine("The methods you can search by are 'Citation number','Title' and 'signing date'\nType 'cite' to search by citiation number, 'title' to search by title, and 'date' to search by siging date.\nEnter method: ");
            string srchmethod = System.Console.ReadLine().ToLower();
            if(srchmethod == "cite"){
                bushcite();
            }else if(srchmethod == "date"){
                bushdate();
            }else if(srchmethod == "title"){
                bushtitle();
            }else{
                System.Console.WriteLine("ERROR CODE C000");
            }
        }
        public static void bushcite(){
            int x = 0;
            while(1 > x){            
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";
                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Bush WHERE citenum LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }  
            }
        }
        public static void bushdate(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Bush WHERE date LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }  
            }
        }
        public static void bushtitle(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Bush WHERE title LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;            
                }
            }  
        }
        //OBAMA--------------------------------------
        public static void obama(){
            System.Console.WriteLine("The methods you can search by are 'Citation number','Title' and 'signing date'\nType 'cite' to search by citiation number, 'title' to search by title, and 'date' to search by siging date.\nEnter method: ");
            string srchmethod = System.Console.ReadLine().ToLower();
            if(srchmethod == "cite"){
                obamacite();
            }else if(srchmethod == "date"){
                obamadate();
            }else if(srchmethod == "title"){
                obamatitle();
            }else{
                System.Console.WriteLine("ERROR CODE D000");
            }
        }
        public static void obamacite(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Obama WHERE citenum LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                } 
            } 
        }
        public static void obamadate(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";
                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Obama WHERE date LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                } 
            } 
        }
        public static void obamatitle(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Obama WHERE title LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                } 
            } 
        }
        //BILL----------------------------------------
        public static void bill(){
            System.Console.WriteLine("The methods you can search by are 'Citation number','Title' and 'signing date'\nType 'cite' to search by citiation number, 'title' to search by title, and 'date' to search by siging date.\nEnter method: ");
            string srchmethod = System.Console.ReadLine().ToLower();
            if(srchmethod == "cite"){
                billcite();
            }else if(srchmethod == "date"){
                billdate();
            }else if(srchmethod == "title"){
                billtitle();
            }else{
                System.Console.WriteLine("ERROR CODE E000");
            }
        }
        public static void billcite(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Clinton WHERE citenum LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;                
                }  
            }
        }
        public static void billdate(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Clinton WHERE date LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                      System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }  
            }
        }
        public static void billtitle(){
            int x = 0;
            while(1 > x){
                System.Console.WriteLine("Enter your search: ");
                string srch = System.Console.ReadLine();
                string cs = @"server=localhost;userid=redacted;password=redacted;database=execorders";

                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT * FROM Clinton WHERE title LIKE @srch;";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@srch", "%" + srch + "%");
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(!rdr.HasRows){
                    System.Console.WriteLine("That doesn't exist in our database.");
                }else if(rdr.HasRows){
                    rdr.Read();
                    System.Console.WriteLine(rdr[0] + ". \nSigned at: " + rdr[1] + ". \nCitation number: " + rdr[3] + ". \npdf file: " + rdr[2]);                   
                    x = 2;
                }
            }  
        }
        //END PRESSIDENTS
    }
}
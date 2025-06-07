    using System;

    namespace ATDU_ATM_MACHINE
    {
        class person
        {
            public string name;
            public int balance;
            public int savings;
            public string location;
            public string accNumber;
            public String cardNumber;
        }
        class Program
        {

            public static void loGin()
            {
                bool wrong = false;
                do
                {
                    Console.Clear();
                    string userPIN = "6969";


                    Console.Write("PLEASE ENTER YOUR PIN NUMBER: ");
                    string PIN = Console.ReadLine();
                   

                    if (PIN == userPIN)
                    {
                        shoeMenYou();
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN please Try again!");
                        wrong = true;
                    }
                    Console.ReadKey();
                    Console.Clear();
                } while (wrong);
            }
            static void Main(string[] args)
            {
                //check, balance, deposit, withdraw,  shoee menu
                loGin();
            }
            public static void shoeMenYou()
            {
                    person person01 = new person();
                    person01.name = "Rastaman Del Mundo";
                    person01.balance = 500;
                    person01.location = "Gottham City";
                    person01.accNumber = "202156691021";
                    person01.cardNumber = "556482211454021";
                    person01.savings = 1000;
                    Console.Clear();
                    Console.WriteLine("===========MENU===========");
                    Console.WriteLine();
                    Console.WriteLine("1. CASH DEPOSIT");
                    Console.WriteLine("2. CASH WITHDRAWAL");
                    Console.WriteLine("3. BALANCE INQUIRY");
                    Console.WriteLine("4. CHANGE PIN");
                    Console.WriteLine("5. TRANSFER MONEY");
                    Console.WriteLine("6. SERVICES");
                    Console.WriteLine("7. MOBILE BANKING ACTIVATION");
                    Console.WriteLine("==========================");

                    string option;


                    double balance = 500;
                    double savings = 1000;
                    Console.Write("OPTION: ");
                    option = Convert.ToString(Console.ReadLine());
                    Console.Clear();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("===========CASH DEPOSIT===========");
                            Console.WriteLine();
                            double depositAmount;
                            Console.Write("ENTER AMOUNT: ");
                            depositAmount = Convert.ToDouble(Console.ReadLine());
                            DateTime dateNow = DateTime.Now;
                            string date = dateNow.ToString("DATE: MM/dd/yyyy");
                            string time = dateNow.ToString("TIME: HH:mm:ss");
                            string location = "Gottham City, Philippines";
                            string cardNumber = "***********4021";
                            String accNumber = "*********021";
                            
                            if (depositAmount >= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("THE PHP " + depositAmount + " IS SUCCESSFULLY DEPOSITED");
                                balance += depositAmount;
                                Console.WriteLine();
                                Console.WriteLine("BALANCE LEFT: PHP " + balance);
                            }
                            Console.WriteLine("==================================");
                            Console.WriteLine();
                            string answer;
                            Console.WriteLine("PRINT RECEIPT?");
                            Console.WriteLine("1. YES");
                            Console.WriteLine("2. NO");
                            Console.Write(": ");
                            answer = Convert.ToString(Console.ReadLine());

                            switch (answer)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                    Console.WriteLine(date);
                                    Console.WriteLine(time);
                                    Console.WriteLine("LOC: " + location);
                                    
                                    Console.WriteLine("CARD NUM: " + cardNumber);
                                    Console.WriteLine("ACCOUNT NUM: " + accNumber);
                                    Console.WriteLine("TRANSACTION: CASH DEPOSIT");
                                    Console.WriteLine("AMOUNT: PHP " + depositAmount);
                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                    Console.WriteLine("AVAILABLE BAL: " + balance);
                                    Console.WriteLine("========================================");

                                    transaction();
                                    break;
                                case "2":
                                    transaction();
                                    break;
                            }
                            break;
                        case "2":
                        
                            DateTime dateNow1 = DateTime.Now;
                            string date1 = dateNow1.ToString("DATE: MM/dd/yyyy");
                            string time1 = dateNow1.ToString("TIME: HH:mm:ss");
                            string location1 = "Gottham City, Philippines";
                            string cardNumber1 = "***********4021";
                            String accNumber1 = "*********021";
                          

                            
                                Console.Clear();
                                Console.WriteLine("===========CASH WITHDRAWAL===========");
                                Console.WriteLine();
                                double withdrawnAmount;
                                Console.Write("ENTER AMOUNT: ");
                                withdrawnAmount = Convert.ToDouble(Console.ReadLine());

                                if (withdrawnAmount <= balance)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("THE PHP " + withdrawnAmount + " IS SUCCESSFULLY WITHDRAWN");
                                    Console.WriteLine();
                                    balance -= withdrawnAmount;
                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                    Console.WriteLine();
                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                    Console.WriteLine(date1);
                                    Console.WriteLine(time1);
                                    Console.WriteLine("LOC: " + location1);
                                   
                                    Console.WriteLine("CARD NUM: " + cardNumber1);
                                    Console.WriteLine("ACCOUNT NUM: " + accNumber1);
                                    Console.WriteLine("TRANSACTION: CASH WITHDRAWAL");
                                    Console.WriteLine("AMOUNT:" + withdrawnAmount);
                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                    Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                    Console.WriteLine("========================================");
                                    transaction();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                    transaction();
                                   
                                }

                           

                            
                            break;
                        case "3":
                        
                            Console.WriteLine("===========BALANCE INQUIRY===========");
                            Console.WriteLine("NAME: " + person01.name);
                            Console.WriteLine("LOCATION: " + person01.location);
                            Console.WriteLine("ACCOUNT NUMBER: " + person01.accNumber);
                            Console.WriteLine("CARD NUMBER: " + person01.cardNumber);
                            Console.WriteLine("BALANCE: PHP " + person01.balance);
                            Console.WriteLine("SAVINGS: PHP " + person01.savings);
                            Console.WriteLine("=====================================");
                            Console.WriteLine();
                            transaction();
                            break;
                        case "4":
                            Console.WriteLine("===========CHANGE PIN===========");
                       
                            string newPin;
                            
                                string userPIN = "6969";


                                Console.Write("ENTER CURRENT PIN CODE: ");
                                string PIN = Console.ReadLine();


                                if (PIN == userPIN)
                                {
                                    Console.Write("ENTER NEW PIN CODE: ");
                                    newPin = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("YOUR PIN NUMBER IS NOW BEEN CHANGED");
                                    transaction();
                                }
                                else
                                {
                                    Console.WriteLine("WRONG PIN PLEASE TRY AGAIN!");
                                  
                                }
                                Console.WriteLine("===============================");
                                Console.ReadKey();
                                Console.Clear();
                            
                            break;
                        case "5":
                            Console.WriteLine("===========TRANSFER MONEY===========");
                        
                            string otherBanks;
                            string opsion;
                            Console.WriteLine("1. SAVINGS");
                            Console.WriteLine("2. OTHERS");
                            Console.WriteLine();
                            Console.Write("OPTION: ");
                            opsion = Convert.ToString(Console.ReadLine());


                            switch (opsion)
                            {
                                case "1":
                                  
                                    Console.WriteLine();
                                    double savingsAmount;
                                    Console.Write("ENTER AMOUNT: ");
                                    savingsAmount = Convert.ToDouble(Console.ReadLine());
                                    DateTime dateNow2 = DateTime.Now;
                                    string date2 = dateNow2.ToString("DATE: MM/dd/yyyy");
                                    string time2 = dateNow2.ToString("TIME: HH:mm:ss");
                                    string location2 = "Gottham City, Philippines";
                                    string cardNumber2 = "***********4021";
                                    String accNumber2 = "*********021";
                                   
                                    
                                        if (savingsAmount <= balance)
                                        {
                                            balance -= savingsAmount;
                                            savings += savingsAmount;
                                            Console.WriteLine("THE PHP " + savingsAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                            Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                            Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                            Console.WriteLine();
                                            Console.WriteLine("===========TRANSACTION RECORD===========");
                                            Console.WriteLine(date2);
                                            Console.WriteLine(time2);
                                            Console.WriteLine("LOC: " + location2);
                                            
                                            Console.WriteLine("CARD NUM: " + cardNumber2);
                                            Console.WriteLine("ACCOUNT NUM: " + accNumber2);
                                            Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                            Console.WriteLine("AMOUNT: PHP " + savingsAmount);
                                            Console.WriteLine("CURRENT BAL: PHP " + balance);
                                            Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                            Console.WriteLine("========================================");
                                            transaction();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("INSUFFICIENT BALANCE");
                                            transaction();
                                           
                                        }
                                  
                                    break;
                                case "2":
                                   
                                    Console.WriteLine("===========TRANSFER MONEY===========");
                                    Console.WriteLine("1. GCASH");
                                    Console.WriteLine("2. UNIONBANK");
                                    Console.WriteLine("3. METROBANK");
                                    Console.WriteLine("4. CHINABANK");
                                    Console.WriteLine("5. BDO");
                                    Console.WriteLine("6. BPI");
                                    Console.Write("OPTION: ");
                                    otherBanks = Convert.ToString(Console.ReadLine());
                                    switch (otherBanks)
                                    {
                                        case "1":
                                            Console.WriteLine();
                                            double gcashAmount;
                                            Console.Write("ENTER AMOUNT: ");
                                            gcashAmount = Convert.ToDouble(Console.ReadLine());
                                            DateTime dateNow3 = DateTime.Now;
                                            string date3 = dateNow3.ToString("DATE: MM/dd/yyyy");
                                            string time3 = dateNow3.ToString("TIME: HH:mm:ss");
                                            string location3 = "Gottham City, Philippines";
                                            string cardNumber3 = "***********4021";
                                            String accNumber3 = "*********021";
                                           
                                          
                                                if (gcashAmount <= balance)
                                                {

                                                    balance -= gcashAmount;
                                                    savings += gcashAmount;
                                                    Console.WriteLine("THE PHP " + gcashAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                                    Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                                    Console.WriteLine();
                                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                                    Console.WriteLine(date3);
                                                    Console.WriteLine(time3);
                                                    Console.WriteLine("LOC: " + location3);
                                                 
                                                    Console.WriteLine("CARD NUM: " + cardNumber3);
                                                    Console.WriteLine("ACCOUNT NUM: " + accNumber3);
                                                    Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                                    Console.WriteLine("AMOUNT:" + gcashAmount);
                                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                                    Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                                    Console.WriteLine("========================================");
                                                    transaction();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                                    transaction();
                                                  
                                                }
                                           
                                            break;
                                        case "2":
                                          
                                            Console.WriteLine();
                                            double unionAmount;
                                            Console.Write("ENTER AMOUNT: ");
                                            unionAmount = Convert.ToDouble(Console.ReadLine());
                                            DateTime dateNow4 = DateTime.Now;
                                            string date4 = dateNow4.ToString("DATE: MM/dd/yyyy");
                                            string time4 = dateNow4.ToString("TIME: HH:mm:ss");
                                            string location4 = "Gottham City, Philippines";
                                            string cardNumber4 = "***********4021";
                                            String accNumber4 = "*********021";
                                           
                                          
                                                if (unionAmount <= balance)
                                                {

                                                    balance -= unionAmount;
                                                    savings += unionAmount;
                                                    Console.WriteLine("THE PHP " + unionAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                                    Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                                    Console.WriteLine();
                                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                                    Console.WriteLine(date4);
                                                    Console.WriteLine(time4);
                                                    Console.WriteLine("LOC: " + location4);
                                                
                                                    Console.WriteLine("CARD NUM: " + cardNumber4);
                                                    Console.WriteLine("ACCOUNT NUM: " + accNumber4);
                                                    Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                                    Console.WriteLine("AMOUNT:" + unionAmount);
                                                    Console.WriteLine("CURRENT BAL: " + balance);
                                                    Console.WriteLine("AVAILABLE BAL: " + balance);
                                                    Console.WriteLine("========================================");
                                                    transaction();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                                    transaction();
                                              
                                                }
                                     
                                            break;
                                        case "3":
                                          
                                            Console.WriteLine();
                                            double chinaAmount;
                                            Console.Write("ENTER AMOUNT: ");
                                            chinaAmount = Convert.ToDouble(Console.ReadLine());
                                            DateTime dateNow5 = DateTime.Now;
                                            string date5 = dateNow5.ToString("DATE: MM/dd/yyyy");
                                            string time5 = dateNow5.ToString("TIME: HH:mm:ss");
                                            string location5 = "Gottham City, Philippines";
                                            string cardNumber5 = "***********4021";
                                            String accNumber5 = "*********021";
                                      
                                           
                                                if (chinaAmount <= balance)
                                                {

                                                    balance -= chinaAmount;
                                                    savings += chinaAmount;
                                                    Console.WriteLine("THE PHP " + chinaAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                                    Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                                    Console.WriteLine();
                                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                                    Console.WriteLine(date5);
                                                    Console.WriteLine(time5);
                                                    Console.WriteLine("LOC: " + location5);
                                                    
                                                    Console.WriteLine("CARD NUM: " + cardNumber5);
                                                    Console.WriteLine("ACCOUNT NUM: " + accNumber5);
                                                    Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                                    Console.WriteLine("AMOUNT: PHP " + chinaAmount);
                                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                                    Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                                    Console.WriteLine("========================================");
                                                    transaction();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                                    transaction();
                                                   
                                                }
                                       
                                            break;
                                        case "4":
                                         
                                            Console.WriteLine();
                                            double bdoAmount;
                                            Console.Write("ENTER AMOUNT: ");
                                            bdoAmount = Convert.ToDouble(Console.ReadLine());
                                            DateTime dateNow6 = DateTime.Now;
                                            string date6 = dateNow6.ToString("DATE: MM/dd/yyyy");
                                            string time6 = dateNow6.ToString("TIME: HH:mm:ss");
                                            string location6 = "Gottham City, Philippines";
                                            string cardNumber6 = "***********4021";
                                            String accNumber6 = "*********021";
                                           
                                          
                                                if (bdoAmount <= balance)
                                                {

                                                    balance -= bdoAmount;
                                                    savings += bdoAmount;
                                                    Console.WriteLine("THE PHP " + bdoAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                                    Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                                    Console.WriteLine();
                                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                                    Console.WriteLine(date6);
                                                    Console.WriteLine(time6);
                                                    Console.WriteLine("LOC: " + location6);
                                                  
                                                    Console.WriteLine("CARD NUM: " + cardNumber6);
                                                    Console.WriteLine("ACCOUNT NUM: " + accNumber6);
                                                    Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                                    Console.WriteLine("AMOUNT: PHP " + bdoAmount);
                                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                                    Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                                    Console.WriteLine("========================================");
                                                    transaction();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                                    transaction();
                                                    
                                                }
                                          
                                            break;
                                        case "5":
                                          
                                            Console.WriteLine();
                                            double bpiAmount;
                                            Console.Write("ENTER AMOUNT: ");
                                            bpiAmount = Convert.ToDouble(Console.ReadLine());
                                            DateTime dateNow7 = DateTime.Now;
                                            string date7 = dateNow7.ToString("DATE: MM/dd/yyyy");
                                            string time7 = dateNow7.ToString("TIME: HH:mm:ss");
                                            string location7 = "Gottham City, Philippines";
                                            string cardNumber7 = "***********4021";
                                            String accNumber7 = "*********021";
                                           
                                          
                                                if (bpiAmount <= balance)
                                                {

                                                    balance -= bpiAmount;
                                                    savings += bpiAmount;
                                                    Console.WriteLine("THE PHP " + bpiAmount + " IS SUCESSFULLY TRANFERED TO SAVINGS");
                                                    Console.WriteLine("CURRENT SAVINGS: PHP " + savings);
                                                    Console.WriteLine("BALANCE LEFT: PHP " + balance);
                                                    Console.WriteLine();
                                                    Console.WriteLine("===========TRANSACTION RECORD===========");
                                                    Console.WriteLine(date7);
                                                    Console.WriteLine(time7);
                                                    Console.WriteLine("LOC: " + location7);
                                              
                                                    Console.WriteLine("CARD NUM: " + cardNumber7);
                                                    Console.WriteLine("ACCOUNT NUM: " + accNumber7);
                                                    Console.WriteLine("TRANSACTION: TRANSFER MONEY");
                                                    Console.WriteLine("AMOUNT: PHP " + bpiAmount);
                                                    Console.WriteLine("CURRENT BAL: PHP " + balance);
                                                    Console.WriteLine("AVAILABLE BAL: PHP " + balance);
                                                    Console.WriteLine("========================================");
                                                    transaction();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("INSUFFICIENT BALANCE");
                                                    transaction();
                                         
                                                }
                                                break;
                                    }
                                    break;

                            }
                            break;
                        case "6":
                        String opxion;
                        Console.WriteLine("===========SERVICES===========");
                        Console.WriteLine("1. REQUEST NEW CHECKBOOK");
                        Console.WriteLine("2. STOP PAYMENT");
                        Console.WriteLine();
                        Console.Write("OPTION: ");
                        opxion = Convert.ToString(Console.ReadLine());

                        switch (opxion)
                        {
                            case "1":
                                String numberBooklets;
                                Console.WriteLine("===========REQUEST NEW CHECKBOOK===========");
                                Console.WriteLine("MY ACCOUNT");
                                Console.WriteLine();
                                Console.WriteLine("===========CHECKBOOK INFORMATION===========");
                                Console.WriteLine("CHECK BOOK WITH NAME");
                                Console.WriteLine("NUMBER OF BOOKLETS: ");
                                Console.Write(": ");
                                numberBooklets = Convert.ToString(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("PLEASE ENTER TO SUBMIT");
                                booklet();
                                Console.ReadKey();
                                break;
                            case "2":
                                string stop;
                                string stopp;
                                string stoppp;
                                string stopppp;
                                string stoppppp;
                                Console.WriteLine("===========STOP PAYMENT ORDER===========");
                                Console.WriteLine("MY ACCOUNT");
                                Console.WriteLine();
                                Console.Write("ENTER WHAT PAYMENT TO STOP:");
                                stop = Convert.ToString(Console.ReadLine());
                                Console.Write("CHECK NO.: ");
                                stopp = Convert.ToString(Console.ReadLine());
                                Console.Write("CHECK DATE: ");
                                stoppp = Convert.ToString(Console.ReadLine());
                                Console.Write("CHECK AMOUNT: ");
                                stopppp = Convert.ToString(Console.ReadLine());
                                Console.Write("REASON: ");
                                stoppppp = Convert.ToString(Console.ReadLine());
                                thankYou();
                                transaction();
                                break;
                        }
                        Console.WriteLine("===========SERVICES===========");
                        break;
                        case "7":
                        String aders;
                        Console.WriteLine("===========MOBILE BANK ACTIVATION===========");
                        Console.WriteLine("1. ACTIVATE");
                        Console.WriteLine("2. DEACTIVATE");
                        Console.Write("OPTION: ");
                        aders = Convert.ToString(Console.ReadLine());
                        switch (aders)
                        {
                            case "1":
                                int otp;
                                Console.Write("ENTER OTP: ");
                                otp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("YOUR MOBILE BANKING IS NOW ACTIVATED");
                                thankYou();
                                transaction();
                                break;
                            case "2":
                                Console.WriteLine("YOUR MOBILE BANKING IS NOW DEACTIVATED");
                                thankYou();
                                transaction();
                                break;
                        }
                        break;
                        default:
                            Console.WriteLine("ERROR WRONG INPUT. PLEASE TRY AGAIN");
                            Console.ReadKey();
                            Console.Clear();
                            shoeMenYou();
                            break;
                    }



                

            }
      
         
            public static void transaction()
            {
                string answer;
                Console.WriteLine();
            
                Console.WriteLine("Do you want another transaction?: ");
                Console.WriteLine("1. YES");
                Console.WriteLine("2. NO");
                Console.Write(": ");
                

                answer = Convert.ToString(Console.ReadLine());
            
                switch (answer)
                {
                    case "1":
                        shoeMenYou();
                        break;
                    case "2":
                        thankYou();
                        Console.WriteLine();
                        Console.WriteLine("NEXT CLIENT PLEASE");
                        Console.ReadKey();
                        Console.WriteLine("======================================");
                        loGin();
                        break;
                }
            }
            public static void thankYou()
            {
                Console.WriteLine();
                Console.WriteLine("THANK YOU FOR USING THE ATDU BANK");
            }
            public static void booklet()
            {
            Console.Clear();
            Console.WriteLine("PLEASE WAIT FOR A ONE WEEK FOR YOUR REQUEST");
            Console.WriteLine("*THE SERVICE CHARGE WILL BE PHP 250*");
            Console.WriteLine();
            transaction();
            }
        }
    }

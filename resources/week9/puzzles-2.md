// CYBER DETECTIVE JUNIOR: CODE MYSTERY ESCAPE ROOM
// =========================================
// This file contains five beginner-friendly programming challenges for the Cyber Detective escape room.
// Each puzzle corresponds to a "digital environment" and focuses on basic C# concepts.
// Instructions for teachers: Separate these puzzles into individual files for distribution
// to students during the activity, along with the corresponding clue fragments.

// =================================================================================
// ENVIRONMENT 1: SECURITY TERMINAL (Variables & Basic Operations)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE JUNIOR: SECURITY TERMINAL                       ║
║                                                                  ║
║  SYSTEM ALERT: Main security terminal locked                     ║
║  MISSION: Fix the security code to gain access                   ║
╚══════════════════════════════════════════════════════════════════╝

The Phantom has locked the main security terminal that controls access
to the city's systems. You need to complete the security code to unlock
the terminal and proceed with your investigation.

Fill in the missing parts of the code to gain access.
*/

using System;

namespace CyberDetectiveJunior.Environment1
{
    class SecurityTerminal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY SECURITY TERMINAL - ACCESS VERIFICATION           ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("ALERT: Security verification required.");
            Console.WriteLine("TASK: Complete the security code by filling in the missing values.");
            Console.WriteLine();
            
            // ===== TASK 1: Create a security code =====
            // The security code must be the number 42
            int securityCode = -1; // CHANGE THIS VALUE to complete the task
            
            // ===== TASK 2: Create an agent ID =====
            // The agent ID must be your name as a string
            string agentId = ""; // CHANGE THIS VALUE to complete the task
            
            // ===== TASK 3: Calculate the access key =====
            // The access key is calculated by multiplying the security code by 10
            int accessKey = 0; // CHANGE THIS VALUE using the securityCode variable
            
            // ===== TASK 4: Set the activation status =====
            // The system must be activated (set to true) to gain access
            bool systemActivated = false; // CHANGE THIS VALUE to complete the task
            
            // ===== VERIFICATION (DO NOT MODIFY) =====
            bool terminalUnlocked = VerifySecurityAccess(securityCode, agentId, accessKey, systemActivated);
            
            if (terminalUnlocked)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ ACCESS GRANTED - Security terminal unlocked");
                Console.WriteLine("\nEVIDENCE RECOVERED: The Phantom seems to be accessing the system from within the city network.");
                Console.WriteLine("\nACCESS CODE TO DATA CENTER: DATA-123");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ ACCESS DENIED - Security verification failed");
                Console.WriteLine("Review your security code and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit terminal...");
            Console.ReadKey();
        }
        
        static bool VerifySecurityAccess(int securityCode, string agentId, int accessKey, bool systemActivated)
        {
            bool task1Complete = securityCode == 42;
            bool task2Complete = !string.IsNullOrWhiteSpace(agentId);
            bool task3Complete = accessKey == securityCode * 10;
            bool task4Complete = systemActivated == true;
            
            // Display individual task status
            Console.WriteLine("\nSystem verification:");
            Console.WriteLine($"- Security Code: {(task1Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- Agent ID: {(task2Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- Access Key: {(task3Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- System Activation: {(task4Complete ? "Valid" : "Invalid")}");
            
            return task1Complete && task2Complete && task3Complete && task4Complete;
        }
    }
}


// =================================================================================
// ENVIRONMENT 2: DATA CENTER (Simple Conditionals)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE JUNIOR: DATA CENTER                             ║
║                                                                  ║
║  SYSTEM ALERT: Data routing system malfunctioning                ║
║  MISSION: Fix the data routing logic to restore system access    ║
╚══════════════════════════════════════════════════════════════════╝

The data routing system in the city's Data Center is malfunctioning.
Critical information is being sent to the wrong destinations.

Repair the simple if-else logic to route data correctly.
*/

using System;

namespace CyberDetectiveJunior.Environment2
{
    class DataCenter
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY DATA CENTER - EMERGENCY RECOVERY MODE            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Security Terminal:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "DATA-123")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Data Center access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Checking data routing system...");
            Console.WriteLine("ALERT: Data routing logic failure detected!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Fix Emergency Data Routing =====
            Console.WriteLine("TASK 1: Repair Emergency Data Routing");
            allTasksComplete &= FixEmergencyRouting();
            
            // ===== TASK 2: Restore User Access Levels =====
            Console.WriteLine("\nTASK 2: Restore User Access Levels");
            allTasksComplete &= RestoreUserAccess();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ DATA CENTER RESTORED - Information flowing correctly");
                Console.WriteLine("\nALERT: System logs show unusual activity.");
                Console.WriteLine("EVIDENCE RECOVERED: The attack happened late at night when most staff were gone.");
                Console.WriteLine("\nACCESS CODE TO COMMUNICATIONS HUB: COMM-456");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ DATA CENTER UNSTABLE - Routing restoration incomplete");
                Console.WriteLine("Fix all logic errors and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit data center...");
            Console.ReadKey();
        }
        
        static bool FixEmergencyRouting()
        {
            Console.WriteLine("Testing emergency data routing...");
            
            // Emergency priority levels
            string emergencyLevel = "High";
            
            // Current routing destination
            string routingDestination = "";
            
            // TASK: Fix the if-else logic to route emergency data correctly
            // Requirements:
            // - "High" emergency level should route to "Emergency Services"
            // - "Medium" emergency level should route to "Response Team"
            // - "Low" emergency level should route to "Monitoring System"
            // - Any other level should route to "System Administrator"
            
            // THE FOLLOWING IF-ELSE LOGIC IS INCORRECT - FIX IT
            if (emergencyLevel == "Low")   // This is WRONG
            {
                routingDestination = "Emergency Services";   // This is WRONG
            }
            else if (emergencyLevel == "Medium")
            {
                routingDestination = "System Administrator";   // This is WRONG
            }
            else if (emergencyLevel == "High")
            {
                routingDestination = "Monitoring System";   // This is WRONG
            }
            else
            {
                routingDestination = "Response Team";   // This is WRONG
            }
            
            Console.WriteLine($"Emergency Level: {emergencyLevel}");
            Console.WriteLine($"Routing Destination: {routingDestination}");
            
            // Verification
            bool isCorrect = (emergencyLevel == "High" && routingDestination == "Emergency Services") ||
                            (emergencyLevel == "Medium" && routingDestination == "Response Team") ||
                            (emergencyLevel == "Low" && routingDestination == "Monitoring System") ||
                            (emergencyLevel != "High" && emergencyLevel != "Medium" && 
                             emergencyLevel != "Low" && routingDestination == "System Administrator");
            
            Console.WriteLine($"Emergency Routing: {(isCorrect ? "FIXED" : "ERROR - Fix the if-else logic")}");
            return isCorrect;
        }
        
        static bool RestoreUserAccess()
        {
            Console.WriteLine("Testing user access system...");
            
            // User access level - varies between 1 and 5
            int accessLevel = 3;
            
            // User access status
            string accessStatus = "";
            
            // TASK: Fix the if-else logic to assign the correct access status
            // Requirements:
            // - Level 5: "Administrator Access"
            // - Level 4: "Manager Access"
            // - Level 3: "Advanced User Access"
            // - Level 2: "Basic User Access"
            // - Level 1: "Guest Access"
            // - Any other level: "No Access"
            
            // THE FOLLOWING IF-ELSE LOGIC IS INCORRECT - FIX IT
            if (accessLevel > 5)   // This is WRONG
            {
                accessStatus = "Administrator Access";
            }
            else if (accessLevel == 3)
            {
                accessStatus = "Manager Access";   // This is WRONG
            }
            else if (accessLevel == 4)
            {
                accessStatus = "Advanced User Access";   // This is WRONG
            }
            else if (accessLevel == 1)
            {
                accessStatus = "Basic User Access";   // This is WRONG
            }
            else
            {
                accessStatus = "No Access";   // This is WRONG for Level 2
            }
            
            Console.WriteLine($"User Access Level: {accessLevel}");
            Console.WriteLine($"Access Status: {accessStatus}");
            
            // Verification
            bool isCorrect = (accessLevel == 5 && accessStatus == "Administrator Access") ||
                            (accessLevel == 4 && accessStatus == "Manager Access") ||
                            (accessLevel == 3 && accessStatus == "Advanced User Access") ||
                            (accessLevel == 2 && accessStatus == "Basic User Access") ||
                            (accessLevel == 1 && accessStatus == "Guest Access") ||
                            (accessLevel < 1 || accessLevel > 5) && accessStatus == "No Access";
            
            Console.WriteLine($"User Access System: {(isCorrect ? "FIXED" : "ERROR - Fix the if-else logic")}");
            return isCorrect;
        }
    }
}


// =================================================================================
// ENVIRONMENT 3: COMMUNICATIONS HUB (Simple Loops)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE JUNIOR: COMMUNICATIONS HUB                      ║
║                                                                  ║
║  SYSTEM ALERT: Communication scanning systems offline            ║
║  MISSION: Repair the scanning systems using loop structures      ║
╚══════════════════════════════════════════════════════════════════╝

The city's Communications Hub cannot properly scan important messages.
The message scanning systems are stuck due to faulty loop structures.

Fix the simple loops to restore communication scanning capabilities.
*/

using System;

namespace CyberDetectiveJunior.Environment3
{
    class CommunicationsHub
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY COMMUNICATIONS HUB - EMERGENCY RECOVERY MODE     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Data Center:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "COMM-456")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Communications Hub access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Checking communication systems...");
            Console.WriteLine("ALERT: Message scanning systems failing!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Fix Message Counter =====
            Console.WriteLine("TASK 1: Repair Message Counter");
            allTasksComplete &= FixMessageCounter();
            
            // ===== TASK 2: Restore Channel Scanner =====
            Console.WriteLine("\nTASK 2: Restore Channel Scanner");
            allTasksComplete &= RestoreChannelScanner();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ COMMUNICATIONS HUB RESTORED - Message scanning operational");
                Console.WriteLine("\nALERT: Phantom message intercepted during scan.");
                Console.WriteLine("EVIDENCE RECOVERED: The Phantom appears to be someone with inside knowledge of the system.");
                Console.WriteLine("\nACCESS CODE TO SECURITY GRID: GRID-789");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ COMMUNICATIONS HUB UNSTABLE - Scanning systems still failing");
                Console.WriteLine("Fix all loop structures and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit communications hub...");
            Console.ReadKey();
        }
        
        static bool FixMessageCounter()
        {
            Console.WriteLine("Testing message counter system...");
            
            // Number of messages to count
            int totalMessages = 10;
            
            // Current count
            int messageCount = 0;
            
            // TASK: Fix the for loop to correctly count from 1 to totalMessages
            // The loop should print each number as it counts
            
            // THE FOLLOWING FOR LOOP IS INCORRECT - FIX IT
            for (int i = 0; i >= totalMessages; i--)   // This is WRONG
            {
                messageCount++;
                Console.WriteLine($"Counting message: {messageCount}");
                
                // Simulated processing delay
                System.Threading.Thread.Sleep(200);
            }
            
            Console.WriteLine($"Total messages counted: {messageCount}");
            
            // Verification
            bool isCorrect = messageCount == totalMessages;
            
            Console.WriteLine($"Message Counter: {(isCorrect ? "FIXED" : "ERROR - Fix the for loop")}");
            return isCorrect;
        }
        
        static bool RestoreChannelScanner()
        {
            Console.WriteLine("Testing communication channel scanner...");
            
            // Communication channels to scan
            string[] channels = { "Emergency", "Public", "Private", "Government", "Media" };
            
            // Channels successfully scanned
            int channelsScanned = 0;
            
            // TASK: Fix the while loop to correctly scan all channels
            // The loop should print each channel as it scans
            
            // THE FOLLOWING WHILE LOOP IS INCORRECT - FIX IT
            int channelIndex = 0;
            while (channelIndex > channels.Length)   // This is WRONG
            {
                Console.WriteLine($"Scanning channel: {channels[channelIndex]}");
                channelsScanned++;
                
                // Simulated scanning delay
                System.Threading.Thread.Sleep(300);
                
                channelIndex++;   // This is correct
            }
            
            Console.WriteLine($"Total channels scanned: {channelsScanned}");
            
            // Verification
            bool isCorrect = channelsScanned == channels.Length;
            
            Console.WriteLine($"Channel Scanner: {(isCorrect ? "FIXED" : "ERROR - Fix the while loop")}");
            return isCorrect;
        }
    }
}


// =================================================================================
// ENVIRONMENT 4: SECURITY GRID (Simple Arrays)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE JUNIOR: SECURITY GRID                           ║
║                                                                  ║
║  SYSTEM ALERT: Security grid offline                             ║
║  MISSION: Restore the grid by fixing array operations            ║
╚══════════════════════════════════════════════════════════════════╝

The city's Security Grid is offline. Key security zones are unprotected
due to failures in the array management system.

Fix the array operations to restore security coverage to all zones.
*/

using System;

namespace CyberDetectiveJunior.Environment4
{
    class SecurityGrid
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY SECURITY GRID - EMERGENCY RECOVERY MODE          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Communications Hub:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "GRID-789")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Security Grid access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Checking security grid systems...");
            Console.WriteLine("ALERT: Security grid array system failing!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Fix Zone Status Array =====
            Console.WriteLine("TASK 1: Repair Zone Status Array");
            allTasksComplete &= FixZoneStatusArray();
            
            // ===== TASK 2: Restore Security Levels =====
            Console.WriteLine("\nTASK 2: Restore Security Levels");
            allTasksComplete &= RestoreSecurityLevels();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ SECURITY GRID RESTORED - All zones protected");
                Console.WriteLine("\nALERT: Security camera footage recovered.");
                Console.WriteLine("EVIDENCE RECOVERED: The Phantom appears to be wearing a blue jacket.");
                Console.WriteLine("\nACCESS CODE TO CENTRAL CONTROL: CONTROL-012");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ SECURITY GRID UNSTABLE - Zone protection incomplete");
                Console.WriteLine("Fix all array operations and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit security grid...");
            Console.ReadKey();
        }
        
        static bool FixZoneStatusArray()
        {
            Console.WriteLine("Testing zone status array...");
            
            // Security zone names
            string[] zoneNames = { "North", "East", "South", "West", "Central" };
            
            // Zone status array (true = secure, false = vulnerable)
            bool[] zoneStatus = new bool[zoneNames.Length];
            
            // TASK: Fix the array operations to set all zones to secure (true)
            // Current operations are missing elements or using wrong indices
            
            // THE FOLLOWING ARRAY OPERATIONS ARE INCORRECT - FIX THEM
            zoneStatus[0] = true;  // This is correct - North zone
            zoneStatus[2] = true;  // This is correct - South zone
            // East, West, and Central zones are not set - must be fixed!
            
            // Display the status of each zone
            for (int i = 0; i < zoneNames.Length; i++)
            {
                string status = zoneStatus[i] ? "Secure" : "VULNERABLE";
                Console.WriteLine($"Zone {zoneNames[i]}: {status}");
            }
            
            // Verification
            bool allZonesSecure = true;
            for (int i = 0; i < zoneStatus.Length; i++)
            {
                if (!zoneStatus[i])
                {
                    allZonesSecure = false;
                    break;
                }
            }
            
            Console.WriteLine($"Zone Status Array: {(allZonesSecure ? "FIXED" : "ERROR - Not all zones secure")}");
            return allZonesSecure;
        }
        
        static bool RestoreSecurityLevels()
        {
            Console.WriteLine("Testing security level system...");
            
            // Security level array (values 1-5, where 5 is highest security)
            int[] securityLevels = { 1, 3, 2, 1, 4 };
            
            // TASK: Fix the array to meet the security requirements:
            // - All security levels must be at least 3
            // - The total sum of all security levels should be at least 20
            
            // THE FOLLOWING ARRAY OPERATIONS ARE INCORRECT - FIX THEM
            // You need to update the values in the securityLevels array
            
            // Display the security levels
            int sum = 0;
            for (int i = 0; i < securityLevels.Length; i++)
            {
                Console.WriteLine($"Security Level {i+1}: {securityLevels[i]}");
                sum += securityLevels[i];
            }
            
            Console.WriteLine($"Total Security Level: {sum}");
            
            // Verification
            bool allLevelsHighEnough = true;
            for (int i = 0; i < securityLevels.Length; i++)
            {
                if (securityLevels[i] < 3)
                {
                    allLevelsHighEnough = false;
                    break;
                }
            }
            
            bool sumHighEnough = sum >= 20;
            bool isCorrect = allLevelsHighEnough && sumHighEnough;
            
            Console.WriteLine($"Security Level Requirements: {(isCorrect ? "MET" : "NOT MET")}");
            Console.WriteLine($"- All levels at least 3: {(allLevelsHighEnough ? "Yes" : "No")}");
            Console.WriteLine($"- Total sum at least 20: {(sumHighEnough ? "Yes" : "No")}");
            
            return isCorrect;
        }
    }
}


// =================================================================================
// ENVIRONMENT 5: CENTRAL CONTROL (Simple Functions)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE JUNIOR: CENTRAL CONTROL                         ║
║                                                                  ║
║  SYSTEM ALERT: Control systems compromised                       ║
║  MISSION: Implement missing functions to restore control         ║
╚══════════════════════════════════════════════════════════════════╝

You've reached the Central Control room - the heart of the city's systems.
The Phantom's location has been traced here, but the control systems are 
not responding due to missing function implementations.

Complete the simple functions to restore control and catch The Phantom!
*/

using System;

namespace CyberDetectiveJunior.Environment5
{
    class CentralControl
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY CENTRAL CONTROL - EMERGENCY RECOVERY MODE        ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Security Grid:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "CONTROL-012")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Central Control access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Checking central control systems...");
            Console.WriteLine("ALERT: Critical functions missing or incomplete!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Implement System Status Function =====
            Console.WriteLine("TASK 1: Implement System Status Function");
            allTasksComplete &= TestSystemStatus();
            
            // ===== TASK 2: Implement Alert Generator Function =====
            Console.WriteLine("\nTASK 2: Implement Alert Generator Function");
            allTasksComplete &= TestAlertGenerator();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ CENTRAL CONTROL RESTORED - All systems functional");
                Console.WriteLine("\nThe Phantom has been tracked! Based on all evidence:");
                Console.WriteLine("- Access from within the city network");
                Console.WriteLine("- Activity during late night hours");
                Console.WriteLine("- Inside knowledge of the system");
                Console.WriteLine("- Wearing a blue jacket");
                Console.WriteLine("\nThe Phantom is revealed to be: JAKE MILLER, night security guard");
                Console.WriteLine("who was recently denied a promotion to systems administrator.");
                Console.WriteLine("\nCONGRATULATIONS! You've successfully identified The Phantom and saved the city!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ CENTRAL CONTROL UNSTABLE - System functions incomplete");
                Console.WriteLine("Implement all functions and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit central control...");
            Console.ReadKey();
        }
        
        // TASK 1: Implement System Status Function
        // This function should return a status message based on the system condition
        // Parameter: systemCondition - integer value representing system condition (0-100)
        // Return value: string message indicating status category
        // Requirements:
        // - 90-100: "Optimal"
        // - 70-89: "Good"
        // - 50-69: "Fair"
        // - 30-49: "Poor"
        // - 0-29: "Critical"
        static string GetSystemStatus(int systemCondition)
        {
            // YOUR CODE HERE: Implement the function to return the correct status
            
            return "Unknown"; // This is WRONG - implement the correct logic
        }
        
        // TASK 2: Implement Alert Generator Function
        // This function should generate an alert message for a system based on its name and status
        // Parameters: systemName - name of the system, systemStatus - status of the system
        // Return value: formatted alert message
        // Requirements:
        // - Format: "ALERT: [systemName] is in [systemStatus] condition!"
        static string GenerateAlertMessage(string systemName, string systemStatus)
        {
            // YOUR CODE HERE: Implement the function to return the formatted message
            
            return ""; // This is WRONG - implement the correct logic
        }
        
        // Test for System Status Function
        static bool TestSystemStatus()
        {
            int[] testConditions = { 95, 75, 60, 40, 20 };
            string[] expectedStatuses = { "Optimal", "Good", "Fair", "Poor", "Critical" };
            
            bool allCorrect = true;
            
            for (int i = 0; i < testConditions.Length; i++)
            {
                int condition = testConditions[i];
                string expected = expectedStatuses[i];
                
                string result = GetSystemStatus(condition);
                bool isCorrect = result == expected;
                
                Console.WriteLine($"System Condition: {condition}, Status: {result}, Expected: {expected}");
                
                if (!isCorrect)
                {
                    allCorrect = false;
                }
            }
            
            Console.WriteLine($"System Status Function: {(allCorrect ? "IMPLEMENTED CORRECTLY" : "IMPLEMENTATION ERROR")}");
            return allCorrect;
        }
        
        // Test for Alert Generator Function
        static bool TestAlertGenerator()
        {
            string[] testSystems = { "Power Grid", "Water Supply", "Transit System" };
            string[] testStatuses = { "Critical", "Good", "Fair" };
            
            bool allCorrect = true;
            
            for (int i = 0; i < testSystems.Length; i++)
            {
                string system = testSystems[i];
                string status = testStatuses[i];
                
                string expected = $"ALERT: {system} is in {status} condition!";
                string result = GenerateAlertMessage(system, status);
                bool isCorrect = result == expected;
                
                Console.WriteLine($"Generated: \"{result}\"");
                Console.WriteLine($"Expected:  \"{expected}\"");
                
                if (!isCorrect)
                {
                    allCorrect = false;
                }
            }
            
            Console.WriteLine($"Alert Generator Function: {(allCorrect ? "IMPLEMENTED CORRECTLY" : "IMPLEMENTATION ERROR")}");
            return allCorrect;
        }
    }
}

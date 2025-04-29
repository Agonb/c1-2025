// CYBER DETECTIVE: CODE MYSTERY ESCAPE ROOM
// =========================================
// This file contains all five programming challenges for the Cyber Detective escape room.
// Each puzzle corresponds to a "digital environment" and focuses on different C# concepts.
// Instructions for teachers: Separate these puzzles into individual files for distribution
// to students during the activity, along with the corresponding clue fragments.

// =================================================================================
// ENVIRONMENT 1: COMPROMISED NETWORK (Variables & Data Types)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE: COMPROMISED NETWORK                            ║
║                                                                  ║
║  SYSTEM ALERT: Critical infrastructure connections failing       ║
║  ERROR: Network variables corrupted                              ║
║  MISSION: Restore proper variable declarations to stabilize      ║
║           city network connections                               ║
╚══════════════════════════════════════════════════════════════════╝

City services are failing as the network variables have been corrupted.
Traffic lights, power grid controls, and emergency communications are offline.

Restore the variable declarations according to the system requirements to
reestablish critical connections.
*/

using System;

namespace CyberDetective.Environment1
{
    class CompromisedNetwork
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY NETWORK TERMINAL - EMERGENCY RECOVERY MODE        ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("ALERT: Primary network variables corrupted.");
            Console.WriteLine("TASK: Restore correct variable declarations to stabilize connections.");
            Console.WriteLine();
            
            // ===== TASK 1: Create the security access key =====
            // Security Protocol: Key must be an alphanumeric string with exactly 10 characters
            // YOUR CODE HERE: Declare and initialize the securityKey variable
            
            
            // ===== TASK 2: Set the access level =====
            // Security Protocol: Access level must be an integer between 1 and 5
            // YOUR CODE HERE: Declare and initialize the accessLevel variable
            
            
            // ===== TASK 3: Enable the security protocol =====
            // Security Protocol: Must be a boolean value set to true for system activation
            // YOUR CODE HERE: Declare and initialize the securityProtocolActive variable
            
            
            // ===== TASK 4: Set the system operational status =====
            // Security Protocol: Must be a double value between 0.0 and 1.0
            // YOUR CODE HERE: Declare and initialize the systemStatus variable
            
            
            // ===== TASK 5: Convert emergency service string code to integer =====
            string emergencyCode = "911";
            // YOUR CODE HERE: Convert emergencyCode to an integer and store in emergencyCodeNumber
            
            
            // ===== VERIFICATION (DO NOT MODIFY) =====
            bool networkStable = VerifyNetworkVariables(
                securityKey, 
                accessLevel, 
                securityProtocolActive, 
                systemStatus, 
                emergencyCodeNumber
            );
            
            if (networkStable)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ NETWORK STABILIZED - Primary connections restored");
                Console.WriteLine("\nALERT: System scan detected fragments of unauthorized code.");
                Console.WriteLine("EVIDENCE RECOVERED: The Phantom accessed the system from a university IP address.");
                Console.WriteLine("\nACCESS CODE TO LOGIC GATEWAY: LOGIC-1337");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ NETWORK UNSTABLE - Connection restoration failed");
                Console.WriteLine("Review your variable declarations and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit terminal...");
            Console.ReadKey();
        }
        
        static bool VerifyNetworkVariables(string securityKey, int accessLevel, bool securityProtocolActive, 
                                         double systemStatus, int emergencyCodeNumber)
        {
            bool task1Complete = securityKey != null && securityKey.Length == 10;
            bool task2Complete = accessLevel >= 1 && accessLevel <= 5;
            bool task3Complete = securityProtocolActive == true;
            bool task4Complete = systemStatus >= 0.0 && systemStatus <= 1.0;
            bool task5Complete = emergencyCodeNumber == 911;
            
            // Display individual task status
            Console.WriteLine("\nSystem diagnostics:");
            Console.WriteLine($"- Security Key: {(task1Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- Access Level: {(task2Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- Security Protocol: {(task3Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- System Status: {(task4Complete ? "Valid" : "Invalid")}");
            Console.WriteLine($"- Emergency Code: {(task5Complete ? "Valid" : "Invalid")}");
            
            return task1Complete && task2Complete && task3Complete && task4Complete && task5Complete;
        }
    }
}

// =================================================================================
// ENVIRONMENT 2: LOGIC GATEWAY (Control Structures)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE: LOGIC GATEWAY                                  ║
║                                                                  ║
║  SYSTEM ALERT: Traffic control and utility routing compromised   ║
║  ERROR: Logical decision structures corrupted                    ║
║  MISSION: Repair the logical flow to restore city services       ║
╚══════════════════════════════════════════════════════════════════╝

The Phantom has altered critical logical pathways controlling traffic signals,
power distribution, and emergency service routing. City streets are in chaos
and vital services are being misdirected.

Debug and fix the conditional logic to restore proper operations.
*/

using System;

namespace CyberDetective.Environment2
{
    class LogicGateway
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY LOGIC GATEWAY - EMERGENCY RECOVERY MODE          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Compromised Network:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "LOGIC-1337")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Logic Gateway access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Scanning logical pathways...");
            Console.WriteLine("ALERT: Multiple logical failures detected!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Fix Traffic Signal Control =====
            Console.WriteLine("TASK 1: Repair Traffic Signal Logic");
            allTasksComplete &= FixTrafficSignalLogic();
            
            // ===== TASK 2: Restore Power Grid Routing =====
            Console.WriteLine("\nTASK 2: Restore Power Grid Routing");
            allTasksComplete &= RestorePowerGridRouting();
            
            // ===== TASK 3: Fix Emergency Service Dispatch =====
            Console.WriteLine("\nTASK 3: Fix Emergency Service Dispatch");
            allTasksComplete &= FixEmergencyDispatch();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ LOGIC GATEWAY RESTORED - City services functioning normally");
                Console.WriteLine("\nALERT: System log analysis complete.");
                Console.WriteLine("EVIDENCE RECOVERED: The attack occurred during the National Programming Competition.");
                Console.WriteLine("\nACCESS CODE TO AUTOMATED DEFENSE SYSTEM: DEFENSE-2727");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ LOGIC GATEWAY UNSTABLE - Service restoration incomplete");
                Console.WriteLine("Fix all logical errors and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit gateway...");
            Console.ReadKey();
        }
        
        static bool FixTrafficSignalLogic()
        {
            // Traffic signal control system is malfunctioning
            // Fix the logical conditions to ensure proper signal operation
            
            int time = 14; // 24-hour format - 2:00 PM
            bool isRushHour = false;
            bool isEmergencyVehiclePresent = false;
            bool isPedestrianWaiting = true;
            string signalStatus = "";
            
            // TASK: Fix the traffic signal logic - the current logic is WRONG
            // Requirements:
            // - During rush hour (7-9 AM and 4-6 PM), prioritize main road traffic
            // - When emergency vehicles present, immediately set signals to allow their passage
            // - When pedestrians are waiting (and no emergency vehicles), allow pedestrian crossing
            // - At night (10 PM - 6 AM), switch to flashing yellow mode
            
            // THE FOLLOWING LOGIC IS INCORRECT - FIX IT
            if (time >= 7 && time <= 9 || time >= 16 && time <= 18)
            {
                isRushHour = false; // This is WRONG
            }
            
            if (isEmergencyVehiclePresent)
            {
                signalStatus = "ALLOW PEDESTRIANS"; // This is WRONG
            }
            else if (isRushHour)
            {
                signalStatus = "PEDESTRIAN PRIORITY"; // This is WRONG
            }
            else if (isPedestrianWaiting)
            {
                signalStatus = "MAIN ROAD PRIORITY"; // This is WRONG
            }
            else if (time > 22 || time < 6)
            {
                signalStatus = "SOLID RED"; // This is WRONG
            }
            else
            {
                signalStatus = "NORMAL OPERATION";
            }
            
            Console.WriteLine($"Traffic Signal Status: {signalStatus}");
            
            // Verification (do not modify)
            bool isLogicCorrect = VerifyTrafficSignalLogic(time, isRushHour, isEmergencyVehiclePresent, 
                                                        isPedestrianWaiting, signalStatus);
                                                        
            Console.WriteLine($"Traffic Signal Logic: {(isLogicCorrect ? "VALID" : "ERROR - Fix the logical conditions")}");
            return isLogicCorrect;
        }
        
        static bool RestorePowerGridRouting()
        {
            // Power grid routing is malfunctioning
            // Fix the switch statement to properly route power
            
            string district = "Downtown";
            int loadPercentage = 85;
            bool isBackupRequired = false;
            string routingDecision = "";
            
            // TASK: Fix the power grid routing logic - the current switch is WRONG
            // Requirements:
            // - Downtown with load >80% should activate auxiliary systems
            // - Residential areas should prioritize continuous service
            // - Industrial zones with load >60% should implement load balancing
            // - Hospital zone should always have backup power ready
            // - Default for other zones should be standard distribution
            
            // THE FOLLOWING SWITCH IS INCORRECT - FIX IT
            switch (district)
            {
                case "Downtown": // This case is WRONG
                    if (loadPercentage < 50)
                    {
                        routingDecision = "ACTIVATE AUXILIARY SYSTEMS";
                    }
                    else
                    {
                        routingDecision = "STANDARD DISTRIBUTION";
                    }
                    break;
                    
                case "Residential": // This case is WRONG
                    routingDecision = "IMPLEMENT LOAD BALANCING";
                    break;
                    
                case "Industrial": // This case is WRONG
                    routingDecision = "PRIORITIZE CONTINUOUS SERVICE";
                    break;
                    
                case "Hospital": // This case is WRONG
                    isBackupRequired = false;
                    routingDecision = "STANDARD DISTRIBUTION";
                    break;
                    
                default:
                    routingDecision = "EMERGENCY SHUTDOWN"; // This is WRONG
                    break;
            }
            
            Console.WriteLine($"Power Grid Routing: {routingDecision}");
            Console.WriteLine($"Backup Power Systems: {(isBackupRequired ? "ACTIVATED" : "STANDBY")}");
            
            // Verification (do not modify)
            bool isLogicCorrect = VerifyPowerGridRouting(district, loadPercentage, isBackupRequired, routingDecision);
            
            Console.WriteLine($"Power Grid Logic: {(isLogicCorrect ? "VALID" : "ERROR - Fix the switch statement")}");
            return isLogicCorrect;
        }
        
        static bool FixEmergencyDispatch()
        {
            // Emergency service dispatch is routing services incorrectly
            // Fix the logical operators to ensure proper emergency response
            
            bool isMedicalEmergency = true;
            bool isFireReported = false;
            bool isPoliceRequired = false;
            bool isNaturalDisaster = false;
            string dispatchDecision = "";
            
            // TASK: Fix the emergency dispatch logic - the current logic is WRONG
            // Requirements:
            // - Medical emergencies require ambulance dispatch
            // - Fire reports require fire department dispatch
            // - Both medical emergencies AND fire should dispatch both services
            // - Police required OR natural disaster should include police dispatch
            // - All natural disasters require all three services
            
            // THE FOLLOWING LOGIC IS INCORRECT - FIX IT
            if (isMedicalEmergency && isFireReported) // This is WRONG
            {
                dispatchDecision = "AMBULANCE ONLY";
            }
            else if (isFireReported || isMedicalEmergency) // This is WRONG
            {
                dispatchDecision = "ALL SERVICES";
            }
            else if (isNaturalDisaster && isPoliceRequired) // This is WRONG
            {
                dispatchDecision = "FIRE DEPARTMENT ONLY";
            }
            else if (isPoliceRequired) // This is WRONG
            {
                dispatchDecision = "NO DISPATCH REQUIRED";
            }
            else
            {
                dispatchDecision = "POLICE ONLY"; // This is WRONG
            }
            
            Console.WriteLine($"Emergency Dispatch: {dispatchDecision}");
            
            // Verification (do not modify)
            bool isLogicCorrect = VerifyEmergencyDispatch(isMedicalEmergency, isFireReported, 
                                                      isPoliceRequired, isNaturalDisaster, dispatchDecision);
                                                      
            Console.WriteLine($"Emergency Dispatch Logic: {(isLogicCorrect ? "VALID" : "ERROR - Fix the logical operators")}");
            return isLogicCorrect;
        }
        
        // Verification methods (DO NOT MODIFY)
        static bool VerifyTrafficSignalLogic(int time, bool isRushHour, bool isEmergencyVehiclePresent, 
                                           bool isPedestrianWaiting, string signalStatus)
        {
            // Implementation hidden - used for verification
            return ((time >= 7 && time <= 9) || (time >= 16 && time <= 18)) == isRushHour &&
                   ((isEmergencyVehiclePresent && signalStatus == "EMERGENCY VEHICLE PRIORITY") ||
                   (isRushHour && !isEmergencyVehiclePresent && signalStatus == "MAIN ROAD PRIORITY") ||
                   (isPedestrianWaiting && !isEmergencyVehiclePresent && !isRushHour && signalStatus == "ALLOW PEDESTRIANS") ||
                   ((time > 22 || time < 6) && !isEmergencyVehiclePresent && signalStatus == "FLASHING YELLOW") ||
                   (!isEmergencyVehiclePresent && !isRushHour && !isPedestrianWaiting && 
                    !(time > 22 || time < 6) && signalStatus == "NORMAL OPERATION"));
        }
        
        static bool VerifyPowerGridRouting(string district, int loadPercentage, bool isBackupRequired, string routingDecision)
        {
            // Implementation hidden - used for verification
            bool isCorrect = true;
            
            if (district == "Downtown" && loadPercentage > 80 && routingDecision != "ACTIVATE AUXILIARY SYSTEMS")
                isCorrect = false;
            else if (district == "Downtown" && loadPercentage <= 80 && routingDecision != "STANDARD DISTRIBUTION")
                isCorrect = false;
            else if (district == "Residential" && routingDecision != "PRIORITIZE CONTINUOUS SERVICE")
                isCorrect = false;
            else if (district == "Industrial" && loadPercentage > 60 && routingDecision != "IMPLEMENT LOAD BALANCING")
                isCorrect = false;
            else if (district == "Industrial" && loadPercentage <= 60 && routingDecision != "STANDARD DISTRIBUTION")
                isCorrect = false;
            else if (district == "Hospital" && (!isBackupRequired || routingDecision != "STANDARD DISTRIBUTION"))
                isCorrect = false;
            else if (district != "Downtown" && district != "Residential" && 
                     district != "Industrial" && district != "Hospital" && 
                     routingDecision != "STANDARD DISTRIBUTION")
                isCorrect = false;
                
            return isCorrect;
        }
        
        static bool VerifyEmergencyDispatch(bool isMedicalEmergency, bool isFireReported, 
                                          bool isPoliceRequired, bool isNaturalDisaster, string dispatchDecision)
        {
            // Implementation hidden - used for verification
            if (isNaturalDisaster && dispatchDecision != "ALL SERVICES")
                return false;
                
            if (isMedicalEmergency && isFireReported && dispatchDecision != "AMBULANCE AND FIRE DEPARTMENT")
                return false;
                
            if (isMedicalEmergency && !isFireReported && !isPoliceRequired && !isNaturalDisaster && 
                dispatchDecision != "AMBULANCE ONLY")
                return false;
                
            if (isFireReported && !isMedicalEmergency && !isPoliceRequired && !isNaturalDisaster && 
                dispatchDecision != "FIRE DEPARTMENT ONLY")
                return false;
                
            if ((isPoliceRequired || isNaturalDisaster) && dispatchDecision.IndexOf("POLICE") < 0)
                return false;
                
            if (!isMedicalEmergency && !isFireReported && !isPoliceRequired && !isNaturalDisaster && 
                dispatchDecision != "NO DISPATCH REQUIRED")
                return false;
                
            return true;
        }
    }
}


// =================================================================================
// ENVIRONMENT 3: AUTOMATED DEFENSE SYSTEM (Loops & Iterations)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE: AUTOMATED DEFENSE SYSTEM                       ║
║                                                                  ║
║  SYSTEM ALERT: Security systems trapped in faulty loop patterns  ║
║  ERROR: Iteration structures corrupted                           ║
║  MISSION: Fix the loops to restore city defense systems          ║
╚══════════════════════════════════════════════════════════════════╝

The city's automated defense systems are malfunctioning due to corrupted loop
structures. Security cameras are stuck in scanning patterns, automated alerts 
are failing, and the intrusion detection system is generating false positives.

Fix the broken loop patterns to restore proper functionality.
*/

using System;
using System.Collections.Generic;

namespace CyberDetective.Environment3
{
    class AutomatedDefenseSystem
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY AUTOMATED DEFENSE SYSTEM - EMERGENCY RECOVERY    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Logic Gateway:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "DEFENSE-2727")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Defense System access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Scanning defense subsystems...");
            Console.WriteLine("ALERT: Multiple loop failures detected!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Fix Security Camera Scanning System =====
            Console.WriteLine("TASK 1: Repair Security Camera Scanning Pattern");
            allTasksComplete &= FixSecurityCameraScanning();
            
            // ===== TASK 2: Restore Intrusion Detection System =====
            Console.WriteLine("\nTASK 2: Restore Intrusion Detection System");
            allTasksComplete &= RestoreIntrusionDetection();
            
            // ===== TASK 3: Fix Alert Generation System =====
            Console.WriteLine("\nTASK 3: Fix Alert Generation System");
            allTasksComplete &= FixAlertGeneration();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ DEFENSE SYSTEMS RESTORED - Security operations functional");
                Console.WriteLine("\nALERT: Pattern analysis complete on recovered code fragments.");
                Console.WriteLine("EVIDENCE RECOVERED: The Phantom's code contains a pattern of prime numbers.");
                Console.WriteLine("\nACCESS CODE TO ENCRYPTION VAULT: CRYPTO-7331");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ DEFENSE SYSTEMS COMPROMISED - Security restoration incomplete");
                Console.WriteLine("Fix all loop structures and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit defense system...");
            Console.ReadKey();
        }
        
        static bool FixSecurityCameraScanning()
        {
            // Security cameras are stuck in an infinite scanning pattern
            // Fix the loops to properly scan all sectors
            
            string[] securitySectors = { "North", "East", "South", "West", "Central" };
            List<string> scannedSectors = new List<string>();
            
            Console.WriteLine("Initiating security scan sequence...");
            
            // TASK: Fix the camera scanning loop - the current loop is WRONG
            // Requirements:
            // - Must scan all sectors in the securitySectors array
            // - Each sector should be scanned exactly once
            // - Scan must complete without infinite looping
            
            // THE FOLLOWING LOOP IS INCORRECT - FIX IT
            for (int i = 0; i <= securitySectors.Length; i--) // This is WRONG
            {
                string sector = securitySectors[i];
                Console.WriteLine($"Scanning {sector} sector...");
                scannedSectors.Add(sector);
                
                // Simulated scan delay
                System.Threading.Thread.Sleep(300);
            }
            
            // Verification (do not modify)
            bool isLoopCorrect = VerifyScanningPattern(securitySectors, scannedSectors);
            
            Console.WriteLine($"Security Camera Scanning: {(isLoopCorrect ? "OPERATIONAL" : "ERROR - Fix the loop structure")}");
            return isLoopCorrect;
        }
        
        static bool RestoreIntrusionDetection()
        {
            // Intrusion detection is failing to properly check security zones
            // Fix the nested loops to ensure complete coverage
            
            Console.WriteLine("Initializing intrusion detection sweep...");
            
            int[][] securityZones = new int[3][];
            securityZones[0] = new int[] { 1, 2, 3 };
            securityZones[1] = new int[] { 4, 5, 6 };
            securityZones[2] = new int[] { 7, 8, 9 };
            
            List<int> checkedZones = new List<int>();
            
            // TASK: Fix the intrusion detection nested loops - the current structure is WRONG
            // Requirements:
            // - Must check all zones in the securityZones 2D array
            // - Each zone should be checked exactly once
            // - Must use a nested loop structure
            
            // THE FOLLOWING NESTED LOOPS ARE INCORRECT - FIX THEM
            int row = 0;
            while (row < securityZones.Length)
            {
                row++; // This is WRONG - incrementing before using the row
                
                int col = 0;
                do
                {
                    // This is WRONG - potential out of bounds
                    if (row < securityZones.Length && col < securityZones[row].Length)
                    {
                        int zone = securityZones[row][col];
                        Console.WriteLine($"Checking zone {zone} for intrusions...");
                        checkedZones.Add(zone);
                        
                        // Simulated detection delay
                        System.Threading.Thread.Sleep(200);
                    }
                    col++;
                } while (col <= securityZones[0].Length); // This is WRONG - potential out of bounds
            }
            
            // Verification (do not modify)
            bool areAllZonesChecked = VerifyIntrusionDetection(securityZones, checkedZones);
            
            Console.WriteLine($"Intrusion Detection System: {(areAllZonesChecked ? "OPERATIONAL" : "ERROR - Fix the nested loops")}");
            return areAllZonesChecked;
        }
        
        static bool FixAlertGeneration()
        {
            // Alert generation system is malfunctioning
            // Fix the loop to correctly process security alerts
            
            string[] alertTypes = { "Motion", "Perimeter", "Fire", "Biohazard", "Cyber" };
            int[] alertCounts = { 3, 0, 2, 0, 5 };
            List<string> generatedAlerts = new List<string>();
            
            Console.WriteLine("Starting alert generation system...");
            
            // TASK: Fix the alert generation loop - the current loop is WRONG
            // Requirements:
            // - Generate alerts only for types with alertCounts > 0
            // - Number of alerts generated should match the count in alertCounts
            // - Use an appropriate loop structure
            
            // THE FOLLOWING LOOP IS INCORRECT - FIX IT
            for (int i = 0; i < alertTypes.Length; i++)
            {
                string alertType = alertTypes[i];
                int count = alertCounts[i];
                
                // This is WRONG - generating alerts for types with count 0
                for (int j = 0; j < 1; j++) // This is WRONG - always generates exactly 1 alert
                {
                    string alertMessage = $"ALERT: {alertType} detected in sector {j+1}";
                    Console.WriteLine(alertMessage);
                    generatedAlerts.Add(alertMessage);
                    
                    // Simulated alert delay
                    System.Threading.Thread.Sleep(200);
                }
            }
            
            // Verification (do not modify)
            bool isAlertLogicCorrect = VerifyAlertGeneration(alertTypes, alertCounts, generatedAlerts);
            
            Console.WriteLine($"Alert Generation System: {(isAlertLogicCorrect ? "OPERATIONAL" : "ERROR - Fix the loop structure")}");
            return isAlertLogicCorrect;
        }
        
        // Verification methods (DO NOT MODIFY)
        static bool VerifyScanningPattern(string[] securitySectors, List<string> scannedSectors)
        {
            // Check if all sectors were scanned exactly once
            if (scannedSectors.Count != securitySectors.Length)
                return false;
                
            foreach (string sector in securitySectors)
            {
                if (!scannedSectors.Contains(sector))
                    return false;
                    
                if (scannedSectors.FindAll(s => s == sector).Count > 1)
                    return false;
            }
            
            return true;
        }
        
        static bool VerifyIntrusionDetection(int[][] securityZones, List<int> checkedZones)
        {
            int totalZones = 0;
            foreach (int[] row in securityZones)
            {
                totalZones += row.Length;
            }
            
            // Check if all zones were checked exactly once
            if (checkedZones.Count != totalZones)
                return false;
                
            for (int i = 0; i < securityZones.Length; i++)
            {
                for (int j = 0; j < securityZones[i].Length; j++)
                {
                    int zone = securityZones[i][j];
                    
                    if (!checkedZones.Contains(zone))
                        return false;
                        
                    if (checkedZones.FindAll(z => z == zone).Count > 1)
                        return false;
                }
            }
            
            return true;
        }
        
        static bool VerifyAlertGeneration(string[] alertTypes, int[] alertCounts, List<string> generatedAlerts)
        {
            int expectedAlertCount = 0;
            for (int i = 0; i < alertCounts.Length; i++)
            {
                expectedAlertCount += alertCounts[i];
            }
            
            // Check if the correct number of alerts were generated
            if (generatedAlerts.Count != expectedAlertCount)
                return false;
                
            // Check if alerts were generated for the right types and counts
            for (int i = 0; i < alertTypes.Length; i++)
            {
                string alertType = alertTypes[i];
                int expectedCount = alertCounts[i];
                
                int actualCount = generatedAlerts.Count(a => a.Contains($"ALERT: {alertType}"));
                
                if (actualCount != expectedCount)
                    return false;
            }
            
            return true;
        }
    }
}


// =================================================================================
// ENVIRONMENT 4: ENCRYPTION VAULT (Functions & Methods)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE: ENCRYPTION VAULT                               ║
║                                                                  ║
║  SYSTEM ALERT: Communications encryption compromised             ║
║  ERROR: Encryption/decryption functions compromised              ║
║  MISSION: Restore secure communication by fixing functions       ║
╚══════════════════════════════════════════════════════════════════╝

The city's secure communications have been compromised. Critical messages are
being intercepted and altered due to damaged encryption and decryption functions.
Emergency services cannot communicate securely, and false information is spreading.

Implement and fix the encryption functions to restore secure communications.
*/

using System;
using System.Text;

namespace CyberDetective.Environment4
{
    class EncryptionVault
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY ENCRYPTION VAULT - EMERGENCY RECOVERY MODE       ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Automated Defense System:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "CRYPTO-7331")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Encryption Vault access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Analyzing encryption subsystems...");
            Console.WriteLine("ALERT: Encryption functions compromised!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Implement Caesar Cipher Encryption =====
            Console.WriteLine("TASK 1: Implement Caesar Cipher Encryption");
            allTasksComplete &= TestCaesarCipher();
            
            // ===== TASK 2: Fix Vigenère Cipher Implementation =====
            Console.WriteLine("\nTASK 2: Fix Vigenère Cipher Implementation");
            allTasksComplete &= TestVigenereCipher();
            
            // ===== TASK 3: Implement Authentication Function =====
            Console.WriteLine("\nTASK 3: Implement Message Authentication");
            allTasksComplete &= TestMessageAuthentication();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ ENCRYPTION VAULT RESTORED - Secure communications reestablished");
                Console.WriteLine("\nALERT: Encrypted message fragment recovered and decrypted.");
                Console.WriteLine("EVIDENCE RECOVERED: \"They said I wasn't good enough. Now they'll see what 'good enough' really means.\"");
                Console.WriteLine("\nACCESS CODE TO CORE SYSTEM: CORE-1729");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ ENCRYPTION VAULT COMPROMISED - Communication security incomplete");
                Console.WriteLine("Fix all encryption functions and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit encryption vault...");
            Console.ReadKey();
        }
        
        // TASK 1: Implement Caesar Cipher Encryption
        // This function should shift each letter by the specified key
        // Letters should wrap around (Z shifts to A)
        // Non-letter characters should remain unchanged
        static string CaesarCipherEncrypt(string plaintext, int key)
        {
            // YOUR CODE HERE: Implement the Caesar cipher encryption
            // The function should shift each letter by the key amount, wrapping around the alphabet
            
            return plaintext; // This is WRONG - implement the proper encryption
        }
        
        // TASK 2: Fix Vigenère Cipher Implementation
        // The current implementation is broken - fix it to properly encrypt using the Vigenère cipher
        static string VigenereCipherEncrypt(string plaintext, string keyword)
        {
            // THE FOLLOWING IMPLEMENTATION IS INCORRECT - FIX IT
            StringBuilder ciphertext = new StringBuilder();
            
            for (int i = 0; i < plaintext.Length; i++)
            {
                char plainChar = plaintext[i];
                
                // This is WRONG - doesn't handle non-letter characters and has incorrect shift logic
                int keyIndex = i % keyword.Length;
                int shift = keyword[keyIndex] - 'A';
                
                // This is WRONG - doesn't properly shift or wrap letters
                char cipherChar = (char)(plainChar + shift);
                
                ciphertext.Append(cipherChar);
            }
            
            return ciphertext.ToString();
        }
        
        // TASK 3: Implement Message Authentication
        // This function should create an authentication code for a message
        // The authentication code should detect if the message has been tampered with
        static string GenerateAuthCode(string message, string secretKey)
        {
            // YOUR CODE HERE: Implement a simple message authentication code (MAC)
            // The function should create a unique code based on the message and secret key
            // This should be something that would change if the message is altered
            
            return "AUTHENTICATION_FAILED"; // This is WRONG - implement a proper auth code
        }
        
        // Verification methods (DO NOT MODIFY)
        static bool TestCaesarCipher()
        {
            string[] testCases = {
                "HELLO",
                "Testing123",
                "DEFEND THE EAST WALL!"
            };
            
            int[] keys = { 3, 7, 13 };
            
            string[] expectedResults = {
                "KHOOR",
                "Alzapun123",
                "QRSVAQ GUR RNFG JNYY!"
            };
            
            bool allCorrect = true;
            
            for (int i = 0; i < testCases.Length; i++)
            {
                string plaintext = testCases[i];
                int key = keys[i];
                string expected = expectedResults[i];
                
                string result = CaesarCipherEncrypt(plaintext, key);
                bool isCorrect = result == expected;
                
                Console.WriteLine($"Caesar Cipher Test {i+1}: {(isCorrect ? "PASSED" : "FAILED")}");
                if (!isCorrect)
                {
                    Console.WriteLine($"  Input: \"{plaintext}\", Key: {key}");
                    Console.WriteLine($"  Expected: \"{expected}\", Got: \"{result}\"");
                }
                
                allCorrect &= isCorrect;
            }
            
            return allCorrect;
        }
        
        static bool TestVigenereCipher()
        {
            string[] testCases = {
                "HELLO",
                "ATTACKATDAWN",
                "DEFEND THE EAST"
            };
            
            string[] keywords = {
                "KEY",
                "LEMON",
                "FORTIFY"
            };
            
            string[] expectedResults = {
                "RIJVS",
                "LXFOPVEFRNHR",
                "JSBXGQ MAT WHHX"
            };
            
            bool allCorrect = true;
            
            for (int i = 0; i < testCases.Length; i++)
            {
                string plaintext = testCases[i];
                string keyword = keywords[i];
                string expected = expectedResults[i];
                
                string result = VigenereCipherEncrypt(plaintext, keyword);
                bool isCorrect = result == expected;
                
                Console.WriteLine($"Vigenère Cipher Test {i+1}: {(isCorrect ? "PASSED" : "FAILED")}");
                if (!isCorrect)
                {
                    Console.WriteLine($"  Input: \"{plaintext}\", Keyword: {keyword}");
                    Console.WriteLine($"  Expected: \"{expected}\", Got: \"{result}\"");
                }
                
                allCorrect &= isCorrect;
            }
            
            return allCorrect;
        }
        
        static bool TestMessageAuthentication()
        {
            string[] messages = {
                "Emergency dispatch to all units",
                "Transfer $1000 to account #12345",
                "Evacuate the building immediately"
            };
            
            string[] secretKeys = {
                "POLICE",
                "SECURE",
                "EMERGENCY"
            };
            
            bool allCorrect = true;
            
            for (int i = 0; i < messages.Length; i++)
            {
                string message = messages[i];
                string secretKey = secretKeys[i];
                
                string authCode = GenerateAuthCode(message, secretKey);
                
                // Test 1: Same message + key should generate same auth code
                string repeatAuthCode = GenerateAuthCode(message, secretKey);
                bool sameAuth = authCode == repeatAuthCode;
                
                // Test 2: Changed message should generate different auth code
                string tamperedMessage = message + ".";
                string tamperedAuthCode = GenerateAuthCode(tamperedMessage, secretKey);
                bool differentAuth = authCode != tamperedAuthCode;
                
                // Test 3: Auth code shouldn't be trivial
                bool nonTrivialAuth = authCode.Length >= 4 && 
                                      authCode != message && 
                                      authCode != secretKey &&
                                      authCode != "AUTHENTICATION_FAILED";
                
                bool isCorrect = sameAuth && differentAuth && nonTrivialAuth;
                
                Console.WriteLine($"Authentication Test {i+1}: {(isCorrect ? "PASSED" : "FAILED")}");
                if (!isCorrect)
                {
                    if (!sameAuth)
                        Console.WriteLine("  Failed: Same message produces different auth codes");
                    if (!differentAuth)
                        Console.WriteLine("  Failed: Tampered message produces same auth code");
                    if (!nonTrivialAuth)
                        Console.WriteLine("  Failed: Auth code is too simple or default");
                }
                
                allCorrect &= isCorrect;
            }
            
            return allCorrect;
        }
    }
}

// =================================================================================
// ENVIRONMENT 5: CORE SYSTEM ACCESS (Arrays & Collections)
// =================================================================================

/*
╔══════════════════════════════════════════════════════════════════╗
║  CYBER DETECTIVE: CORE SYSTEM ACCESS                             ║
║                                                                  ║
║  SYSTEM ALERT: Core system fragmented and locked                 ║
║  ERROR: Access codes scattered in data arrays                    ║
║  MISSION: Manipulate arrays to recover access and stop The       ║
║           Phantom before complete system takeover                ║
╚══════════════════════════════════════════════════════════════════╝

You've reached the heart of the city's operating system. The Phantom has
fragmented the system and hidden access codes throughout arrays and data
collections. Time is critical - you must reconstruct the data correctly
to regain control before The Phantom completes their takeover.

This is the final challenge - restore access and identify The Phantom!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberDetective.Environment5
{
    class CoreSystemAccess
    {
        static void Main(string[] args)
        {
            // Verify access code from previous environment
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  CITY CORE SYSTEM - EMERGENCY RECOVERY MODE            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            
            Console.WriteLine("Enter access code from Encryption Vault:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "CORE-1729")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid access code. Core System access denied.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.WriteLine("\nAccess granted. Analyzing system fragments...");
            Console.WriteLine("ALERT: Core system heavily fragmented!");
            Console.WriteLine();
            
            bool allTasksComplete = true;
            
            // ===== TASK 1: Restore Access Control Array =====
            Console.WriteLine("TASK 1: Restore Access Control Array");
            allTasksComplete &= RestoreAccessControlArray();
            
            // ===== TASK 2: Reconstruct User Permissions =====
            Console.WriteLine("\nTASK 2: Reconstruct User Permissions");
            allTasksComplete &= ReconstructUserPermissions();
            
            // ===== TASK 3: Recover System Command Sequence =====
            Console.WriteLine("\nTASK 3: Recover System Command Sequence");
            allTasksComplete &= RecoverCommandSequence();
            
            // ===== RESULT =====
            if (allTasksComplete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✓ CORE SYSTEM RESTORED - Full access regained");
                Console.WriteLine("\nFinal pieces of evidence allow you to identify The Phantom:");
                Console.WriteLine("- University IP address origin");
                Console.WriteLine("- Attack during programming competition");
                Console.WriteLine("- Pattern of prime numbers in code");
                Console.WriteLine("- Message about rejection");
                Console.WriteLine("- Final signature pattern: 0xA7");
                Console.WriteLine("\nThe Phantom is Alex Chen, a brilliant but rejected applicant to the");
                Console.WriteLine("city's elite programming academy who wanted to prove their skills.");
                Console.WriteLine("\nCONGRATULATIONS! You've successfully identified The Phantom and saved the city!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n✗ CORE SYSTEM UNSTABLE - Access restoration incomplete");
                Console.WriteLine("Fix all array manipulations and try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.WriteLine("\nPress any key to exit core system...");
            Console.ReadKey();
        }
        
        static bool RestoreAccessControlArray()
        {
            // The access control array has been corrupted
            // Fix the array manipulations to restore proper access
            
            Console.WriteLine("Analyzing access control fragments...");
            
            // Corrupted access control array
            int[] accessLevels = { 3, 7, 1, 5, 9, 2, 8, 4, 6 };
            
            // TASK: Implement the following operations on the accessLevels array
            // 1. Sort the array in ascending order
            // 2. Find and print the median value
            // 3. Find and print the sum of all values
            // 4. Create a new array containing only access levels >= 5
            
            Console.WriteLine("Current access levels: " + string.Join(", ", accessLevels));
            
            // Step 1: Sort the array in ascending order
            // YOUR CODE HERE
            
            
            Console.WriteLine("Sorted access levels: " + string.Join(", ", accessLevels));
            
            // Step 2: Find and print the median value
            int median = 0; // This is WRONG - calculate the actual median
            Console.WriteLine($"Median access level: {median}");
            
            // Step 3: Find and print the sum of all values
            int sum = 0; // This is WRONG - calculate the actual sum
            Console.WriteLine($"Sum of all access levels: {sum}");
            
            // Step 4: Create a new array with only access levels >= 5
            int[] highLevels = new int[0]; // This is WRONG - create the filtered array
            Console.WriteLine("High-level access: " + string.Join(", ", highLevels));
            
            // Verification (do not modify)
            bool isArrayRestored = VerifyAccessArray(accessLevels, median, sum, highLevels);
            
            Console.WriteLine($"Access Control Array: {(isArrayRestored ? "RESTORED" : "CORRUPTED - Fix the array operations")}");
            return isArrayRestored;
        }
        
        static bool ReconstructUserPermissions()
        {
            // User permission collections have been scrambled
            // Use list operations to restore them
            
            Console.WriteLine("Reconstructing user permission database...");
            
            // Lists of users with different permission levels
            List<string> adminUsers = new List<string> { "sysadmin", "netadmin", "secadmin" };
            List<string> powerUsers = new List<string> { "operator1", "operator2", "developer", "analyst" };
            List<string> regularUsers = new List<string> { "user1", "user2", "user3", "user4", "user5" };
            
            // TASK: Perform the following operations on the user permission lists
            // 1. Create an allUsers list containing all users from all permission groups
            // 2. Remove any user with "admin" in their name from the powerUsers list
            // 3. Add "emergencyUser" to the regularUsers list
            // 4. Create a specialUsers list containing users from adminUsers and powerUsers
            //    whose names contain the digit '1'
            
            // Step 1: Create allUsers list
            List<string> allUsers = new List<string>(); // This is WRONG - combine all users
            Console.WriteLine("All users: " + string.Join(", ", allUsers));
            
            // Step 2: Remove admin users from power users
            // YOUR CODE HERE
            
            
            Console.WriteLine("Updated power users: " + string.Join(", ", powerUsers));
            
            // Step 3: Add emergency user
            // YOUR CODE HERE
            
            
            Console.WriteLine("Updated regular users: " + string.Join(", ", regularUsers));
            
            // Step 4: Create special users list
            List<string> specialUsers = new List<string>(); // This is WRONG - find users with '1'
            Console.WriteLine("Special users: " + string.Join(", ", specialUsers));
            
            // Verification (do not modify)
            bool isPermissionsRestored = VerifyUserPermissions(adminUsers, powerUsers, regularUsers, 
                                                           allUsers, specialUsers);
                                                           
            Console.WriteLine($"User Permissions: {(isPermissionsRestored ? "RECONSTRUCTED" : "CORRUPTED - Fix the list operations")}");
            return isPermissionsRestored;
        }
        
        static bool RecoverCommandSequence()
        {
            // The system command sequence dictionary has been scrambled
            // Repair it using dictionary operations
            
            Console.WriteLine("Recovering system command sequence...");
            
            // Corrupted command sequence dictionary
            Dictionary<string, int> commandPriority = new Dictionary<string, int>
            {
                { "REBOOT", 5 },
                { "SCAN", 2 },
                { "BACKUP", 3 },
                { "RESTORE", 6 },
                { "SHUTDOWN", 1 }
            };
            
            // TASK: Perform the following operations on the commandPriority dictionary
            // 1. Add a new command "LOCKDOWN" with priority 4
            // 2. Remove the "SHUTDOWN" command
            // 3. Change the priority of "RESTORE" to 7
            // 4. Create a new dictionary with only high-priority commands (priority >= 5)
            
            // Step 1: Add LOCKDOWN command
            // YOUR CODE HERE
            
            
            // Step 2: Remove SHUTDOWN command
            // YOUR CODE HERE
            
            
            // Step 3: Change RESTORE priority
            // YOUR CODE HERE
            
            
            Console.WriteLine("Updated command priorities:");
            foreach (var command in commandPriority)
            {
                Console.WriteLine($"- {command.Key}: {command.Value}");
            }
            
            // Step 4: Create high-priority commands dictionary
            Dictionary<string, int> highPriorityCommands = new Dictionary<string, int>(); // This is WRONG
            
            Console.WriteLine("High-priority commands:");
            foreach (var command in highPriorityCommands)
            {
                Console.WriteLine($"- {command.Key}: {command.Value}");
            }
            
            // Verification (do not modify)
            bool isSequenceRecovered = VerifyCommandSequence(commandPriority, highPriorityCommands);
            
            Console.WriteLine($"Command Sequence: {(isSequenceRecovered ? "RECOVERED" : "CORRUPTED - Fix the dictionary operations")}");
            return isSequenceRecovered;
        }
        
        // Verification methods (DO NOT MODIFY)
        static bool VerifyAccessArray(int[] sortedArray, int median, int sum, int[] highLevels)
        {
            // Check if array is sorted
            for (int i = 1; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] < sortedArray[i-1])
                    return false;
            }
            
            // Check median
            int expectedMedian = sortedArray[sortedArray.Length / 2];
            if (median != expectedMedian)
                return false;
                
            // Check sum
            int expectedSum = sortedArray.Sum();
            if (sum != expectedSum)
                return false;
                
            // Check high levels
            int[] expectedHighLevels = sortedArray.Where(x => x >= 5).ToArray();
            if (highLevels.Length != expectedHighLevels.Length)
                return false;
                
            for (int i = 0; i < highLevels.Length; i++)
            {
                if (highLevels[i] != expectedHighLevels[i])
                    return false;
            }
            
            return true;
        }
        
        static bool VerifyUserPermissions(List<string> adminUsers, List<string> powerUsers, 
                                       List<string> regularUsers, List<string> allUsers, 
                                       List<string> specialUsers)
        {
            // Original lists for verification
            List<string> originalAdmins = new List<string> { "sysadmin", "netadmin", "secadmin" };
            List<string> expectedPowerUsers = new List<string> { "operator1", "operator2", "developer", "analyst" }
                                             .Where(u => !u.Contains("admin")).ToList();
            List<string> expectedRegularUsers = new List<string> { "user1", "user2", "user3", "user4", "user5", "emergencyUser" };
            
            // Check adminUsers unchanged
            if (!adminUsers.SequenceEqual(originalAdmins))
                return false;
                
            // Check powerUsers correct
            if (!powerUsers.OrderBy(x => x).SequenceEqual(expectedPowerUsers.OrderBy(x => x)))
                return false;
                
            // Check regularUsers correct
            if (!regularUsers.OrderBy(x => x).SequenceEqual(expectedRegularUsers.OrderBy(x => x)))
                return false;
                
            // Check allUsers contains all users
            List<string> expectedAllUsers = new List<string>();
            expectedAllUsers.AddRange(adminUsers);
            expectedAllUsers.AddRange(powerUsers);
            expectedAllUsers.AddRange(regularUsers);
            
            if (allUsers.Count != expectedAllUsers.Count || 
                !allUsers.OrderBy(x => x).SequenceEqual(expectedAllUsers.OrderBy(x => x)))
                return false;
                
            // Check specialUsers correct
            List<string> expectedSpecialUsers = new List<string>();
            expectedSpecialUsers.AddRange(adminUsers.Where(u => u.Contains("1")));
            expectedSpecialUsers.AddRange(powerUsers.Where(u => u.Contains("1")));
            
            if (!specialUsers.OrderBy(x => x).SequenceEqual(expectedSpecialUsers.OrderBy(x => x)))
                return false;
                
            return true;
        }
        
        static bool VerifyCommandSequence(Dictionary<string, int> commandPriority, 
                                       Dictionary<string, int> highPriorityCommands)
        {
            // Expected command priority after modifications
            Dictionary<string, int> expectedCommands = new Dictionary<string, int>
            {
                { "REBOOT", 5 },
                { "SCAN", 2 },
                { "BACKUP", 3 },
                { "RESTORE", 7 },
                { "LOCKDOWN", 4 }
            };
            
            // Check commandPriority correct
            if (commandPriority.Count != expectedCommands.Count)
                return false;
                
            foreach (var command in expectedCommands)
            {
                if (!commandPriority.ContainsKey(command.Key) || 
                    commandPriority[command.Key] != command.Value)
                    return false;
            }
            
            // Check highPriorityCommands correct
            Dictionary<string, int> expectedHighPriority = expectedCommands
                                                         .Where(c => c.Value >= 5)
                                                         .ToDictionary(c => c.Key, c => c.Value);
                                                         
            if (highPriorityCommands.Count != expectedHighPriority.Count)
                return false;
                
            foreach (var command in expectedHighPriority)
            {
                if (!highPriorityCommands.ContainsKey(command.Key) || 
                    highPriorityCommands[command.Key] != command.Value)
                    return false;
            }
            
            return true;
        }
    }
}


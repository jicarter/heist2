using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
            public class Bank
            {
                 public int CashOnHand { get; set; }
                 public int AlarmScore { get; set; }
                 public int VaultScore { get; set; }
                 public int SecurityGuardScore { get; set; }
                 public bool IsSecure { get; set; }
                 public void TotalSecurity()
                 {
                      if (CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                      {
                          IsSecure = false;
                      } else
                      {
                          IsSecure = true;
                      }
                 } 
            }

            public interface IRobber
            {
                public string Name { get; set; }
                public int SkillLevel { get; set; }
                public int PercentageCut { get; set; }

                public void PerformSkill(Bank bank)
                {

                }

            }

            public class Hacker : IRobber 
            {
               public string Name { get; set; }
               public int SkillLevel {get ; set; }
               public int PercentageCut { get; set; }

                public void PerformSkill(Bank bank)
                {
                   Console.WriteLine($"{Name} is hacking the alarm system!");
                }
            }
            public class Muscle : IRobber 
            {
               public string Name { get; set; }
               public int SkillLevel {get ; set; }
               public int PercentageCut { get; set; }

                public void PerformSkill(Bank bank)
                {
                   Console.WriteLine($"{Name} is attempting to dispatch the guards!");
                }
            }
            public class LockSpecialist : IRobber 
            {
               public string Name { get; set; }
               public int SkillLevel {get ; set; }
               public int PercentageCut { get; set; }

                public void PerformSkill(Bank bank)
                {
                   Console.WriteLine($"{Name} is picking the lock!");
                }
            }
        }
    }


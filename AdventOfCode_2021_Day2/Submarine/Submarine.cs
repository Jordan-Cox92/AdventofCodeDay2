using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace Submarine {
    /// <summary>
    /// This is the submarine class.  For this coding challenge, your submarine needs to be able to accept a list of commands.
    /// 
    /// Each command will need to update a variable that is tracking the submarine depth or the horizontal position.  
    /// 
    ///     `forward X` increases the horizontal position by X units.
    ///     `down X` increases the depth by X units.
    ///     `up X` decreases the depth by X units.
    /// 
    /// </summary>
    public class Submarine {

        public Submarine(string InstructionFile = "input.txt") : this(File.ReadAllLines(InstructionFile)) { }

        /// <summary>
        /// Main Application Entry Point 
        /// 
        /// Goals:  Loop through a list of instructions
        /// For each instruction, process the instruction to navigate the submarine.
        /// </summary>
        /// <param name="Instructions"></param>
        public Submarine(string[] Instructions) {

            int forward = 0;
            int depth = 0;
            int sum = forward * depth;

            foreach (string Instruction in Instructions)
            {
                string[] commands = Instruction.Split(" ");
                switch(commands[0])
                {
                    case "forward5":
                        forward += int.Parse(commands[5]);
                        break;
                    case "down5":
                        depth += int.Parse(commands[5]);
                        break;
                    case "forward8":
                        forward += int.Parse(commands[8]);
                        break;
                    case "up3":
                        depth -= int.Parse(commands[3]);
                        break;
                    case "down8":
                        depth += int.Parse(commands[8]);
                        break;
                    case "forward2":
                        forward += int.Parse(commands[2]);
                        break;

                }
                return sum;
                
            }
            



            
        }


        public int Answer_Part1 { get; private set; }

        public int Answer_Part2 { get; private set; }
    }
}
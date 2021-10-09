﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Milestone2_PRG282.DataAccessLayer;


namespace Project_Milestone2_PRG282.BusinessLayer
{
    class StudentModule
    {
        public StudentModule(int stud, List<string> mods)
        {
            this.stud = stud;
            this.mods = mods;
        }
        DataHandler dh = new DataHandler();
        public int stud { get; set; }
        public List<string> mods {get; set;}
        public string UpdateModules()
        {
            return dh.UpdateStudentModule(this.stud, this.mods) ? "Success" : "Failed";
        }
        public void sendInsertToDataHandler()
        {
            dh.addStudentModules(stud, mods);
        }
    }
}

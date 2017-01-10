using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Phase_Task
    {
        public struct Phase_TaskInfo
        {
            public static String ID = "ID";
            public static String Code = "Code";
            public static String P_ID = "P_ID";
            public static String S_ID = "S_ID";
            public static String Progress_Percentage = "Progress_Percentage";
            public static String Completion_Date = "Completion_Date";
        }
        float Progress_Percentage;
        String Completion_Date;
        Project project;
        Task_Category task_Category;
        Specialist specialist;
        Phase_Category phase_Category;

        public float Progress_Percentage1
        {
            get
            {
                return Progress_Percentage;
            }

            set
            {
                Progress_Percentage = value;
            }
        }

        public string Completion_Date1
        {
            get
            {
                return Completion_Date;
            }

            set
            {
                Completion_Date = value;
            }
        }

        public Project Project
        {
            get
            {
                return project;
            }

            set
            {
                project = value;
            }
        }

        public Task_Category Task_Category
        {
            get
            {
                return task_Category;
            }

            set
            {
                task_Category = value;
            }
        }

        public Specialist Specialist
        {
            get
            {
                return specialist;
            }

            set
            {
                specialist = value;
            }
        }

        public Phase_Category Phase_Category
        {
            get
            {
                return phase_Category;
            }

            set
            {
                phase_Category = value;
            }
        }
    }
}

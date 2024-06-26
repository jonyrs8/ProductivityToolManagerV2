﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    /// <summary>
    /// THIS CLASS SHOULD ONLY BE USED TO EXTRACT DATA FROM TABLE - TASKS_YEAR_OBJECTIVES
    /// NAME: TASKS_YEAR_OBJECTIVES
    /// COLUNS: YEAR, TASKS_OBJECTIVES 
    /// </summary>
    public class TaskYearObjectivesData
    {
        #region METHODS
        /// <summary>
        /// METHOD TO EXTRACT ALL DATA FROM TASKS YEAR OBJECTIVES
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static DataTable GetTasksYearObjectivesData(out string error)
        {
            string table = "TASKS_YEAR_OBJECTIVES";
            DataTable dataTable = DatabaseConnection.GetTableData(out error, table);
            return dataTable;
        }
        #endregion
    }
}

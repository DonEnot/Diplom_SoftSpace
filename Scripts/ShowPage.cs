using System;
using System.Collections.Generic;
using Npgsql;
using SoftSpace_web.Models;
namespace  SoftSpace_web.Script
{
    static class   ShowPage
    {
        
        public static Edit TakePages(string name_table,string sql_com,int numb_page,int count_items_on_page )
        {
            Edit edit = new Edit();
            List<List<string>> tmp_data = new List<List<string>>();
            DbConfig.UseSqlCommand("SELECT count(id) from  " + name_table, tmp_data);
                
            if(tmp_data.Count > 0)
            {
                edit.count_pages = Convert.ToInt32(tmp_data[0][0]) / count_items_on_page;
                int items = Convert.ToInt32(tmp_data[0][0]);
                if((items % count_items_on_page != 0)&&(items > count_items_on_page))
                {
                   edit.count_pages++;
                }
            }

            DbConfig.UseSqlCommand(sql_com,edit.list);
            edit.currect_number = numb_page;
            
            return edit;
        }
    }
}
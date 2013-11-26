using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseClass._Library
{
    public class PaginationLibrary
    {
        public int max_item_per_page = 1;
        public int current_page = 1;
        public int total_item = 1;
        public void set_max_item_per_page(int number)
        {
            this.max_item_per_page = number;
        }
        public void set_current_page(int number)
        {
            this.current_page = number;
        }
        public void set_total_item(int number)
        {
            this.total_item = number;
        }
        public int start_point { get; set; }
        public Boolean can_next_page { get; set; }
        public Boolean can_prev_page { get; set; }
        public Boolean can_first_page { get; set; }
        public Boolean can_last_page { get; set; }
        public int total_page { get; set; }

        public Boolean update()
        {
            try
            {
                this.start_point = (this.current_page - 1) * this.max_item_per_page;
                if (start_point < 0) start_point = 0;
                this.total_page = total_item / max_item_per_page + 1;
                if (this.total_item % max_item_per_page == 0)
                {
                    this.total_page--;
                }
                if (this.total_page <= 0) this.total_page = 1;
                this.can_first_page = this.current_page == 1 ? false : true;
                this.can_last_page = this.current_page == this.total_page ? false : true;
                this.can_next_page = this.current_page < this.total_page ? true : false;
                this.can_prev_page = this.current_page > 1 ? true : false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
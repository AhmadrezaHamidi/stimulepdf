using System;
using System.Collections.Generic;
using System.Text;

namespace VstaabnerWpf.Model
{
   public  class TbBook
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long seriyal { get; set; }
        public string Title { get; set; }

        public string Publisher { get; set; }
        public List<TbBookAndShelve> bookAndShelvecs { get; set; }
    }
}


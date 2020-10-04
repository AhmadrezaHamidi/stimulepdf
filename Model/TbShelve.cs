using System;
using System.Collections.Generic;
using System.Text;

namespace VstaabnerWpf.Model
{
     public class TbShelve
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Titele { get; set; }
        public TbUser User { get; set; }
        public string UserId { get; set; }

        public List<TbBookAndShelve> bookAndShelvecs { get; set; }
    }
}

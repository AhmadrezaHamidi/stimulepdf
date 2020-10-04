using System;
using System.Collections.Generic;
using System.Text;

namespace VstaabnerWpf.Model
{
    public class TbBookAndShelve
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public int ShelveId { get; set; }
        public TbBook Booke { get; set; }
        public TbShelve shelve { get; set; }
    }
}

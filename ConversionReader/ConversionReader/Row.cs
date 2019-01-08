using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionReader
{
    public class Row
    {
        private int id;
        private string listId;
        private string input1;
        private string input2;
        private string output;

        public int Id
        {
            get { return id; }
        }

        public string ListId
        {
            get { return listId; }
        }

        public string Input1
        {
            get { return input1; }
        }

        public string Input2
        {
            get { return input2; }
        }

        public string Output
        {
            get { return output; }
        }

        public Row(int id, string listId, string input1, string input2, string output)
        {
            this.id = id;
            this.listId = listId;
            this.input1 = input1;
            this.input2 = input2;
            this.output = output;
        }
    }
}

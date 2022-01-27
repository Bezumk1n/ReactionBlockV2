using ReactionBlockV2.Models;
using System.Collections.Generic;

namespace ReactionBlockV2
{
    internal class MainViewModel
    {
        private List<object> _ReactionBlock = new List<object>();
        public List<object> ReactionBlock
        { 
            get { return _ReactionBlock; }
            set { _ReactionBlock = value; }
        }
        private int _Rows = 8;
        public int Rows
        {
            get => _Rows;
            set 
            {
                _Rows = value;
            }
        }
        private int _Columns = 12;
        public int Columns
        {
            get => _Columns;
            set
            {
                _Columns = value;
            }
        }
        public MainViewModel()
        {
            for (int i = 0; i<96;i++)
                _ReactionBlock.Add(new Cell() { Index = i });
        }
    }
}
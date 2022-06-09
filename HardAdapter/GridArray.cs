using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardAdapter
{
    class GridArray
    {
        MyArray _myArray;
        DataGridView _dataGridView;

        public GridArray(DataGridView dataGridView, MyArray myArray)
        {
            _dataGridView = dataGridView;
            _myArray = myArray;
            dataGridView.ColumnCount = myArray.N;
            dataGridView.RowCount = myArray.N;
            
        }
        public void ShowInfo()
        {
            for (int i = 0; i < _myArray.N; i++)
                for (int j = 0; j < _myArray.N; j++)
                {
                    _dataGridView.Rows[i].Height = 30;
                    _dataGridView.Columns[i].Width = 30;
                    _dataGridView[i, j].Value = _myArray.Array[j, i].ToString();
                    if (_myArray.Array[j, i] == 0)
                        _dataGridView[i, j].Style.BackColor = Color.Black;
                    else
                        _dataGridView[i, j].Style.BackColor = Color.White;
                }
        }
    }
}

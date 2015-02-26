using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guitar32.Utilities.UI
{

    /// <summary>
    /// A utility class for additional basic helpers to control DataGridView objects
    /// </summary>
    public class DataGridViews
    {

        /// <summary>
        /// Gets the value of the cell column index from a currently selected row.
        /// Works only for non-MultiSelect DataGridView objects.
        /// </summary>
        /// <param name="columnIndex">The column index from the currently selected row</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        /// <returns>The current value of the specified position, otherwise, FALSE if no current row is selected or columnIndex exceeds the total number of columns</returns>
        static public object GetSelectedValue(int columnIndex, ref DataGridView dataGridView) {
            if (dataGridView.SelectedRows.Count == 0) {
                return false;
            }
            if (columnIndex >= dataGridView.CurrentRow.Cells.Count) {
                return false;
            }
            return dataGridView.CurrentRow.Cells[columnIndex].Value;
        }
        /// <summary>
        /// Gets the value of the cell column name from a currently selected row
        /// Works only for non-MultiSelect DataGridView objects
        /// </summary>
        /// <param name="columnName">The column name from the currently selected row</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        /// <returns>The current value of the specified position, otherwise, FALSE if no current row is selected or columnIndex exceeds the total number of columns</returns>
        static public object GetSelectedValue(String columnName, ref DataGridView dataGridView) {
            for (int i = 0; i < dataGridView.Columns.Count; i++) {
                if (dataGridView.Columns[i].Name.ToUpper().Equals(columnName.ToUpper())) {
                    return GetSelectedValue(i, ref dataGridView);
                }
            }
            return false;
        }


        /// <summary>
        /// Get the value of a specified position in DataGridView
        /// </summary>
        /// <param name="columnIndex">Index of column</param>
        /// <param name="rowIndex">Index of row</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        /// <returns>The current value of the specified position, otherwise, FALSE</returns>
        static public object GetValue(int columnIndex, int rowIndex, ref DataGridView dataGridView) {
            if (rowIndex >= dataGridView.RowCount) {
                return false;
            }
            if (columnIndex >= dataGridView.Rows[rowIndex].Cells.Count) {
                return false;
            }
            return dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
        }


        /// <summary>
        /// Select a row. If target DataGridView is MultiSelect, then the specified row index will be included in the selection.
        /// </summary>
        /// <param name="index">The index of the row to be selected</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        static public void SelectIndex(int index, ref DataGridView dataGridView) {
            if (index >= dataGridView.RowCount) {
                return;
            }

            if (dataGridView.MultiSelect) {
                dataGridView.Rows[index].Selected = true;
            }
            else {
                for (int i = 0; i < dataGridView.RowCount; i++) {
                    dataGridView.Rows[i].Selected = (index == i);
                    if (index == i) {
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Select multiple rows. Works only when the target DataGridView is MultiSelect
        /// </summary>
        /// <param name="indices">The array of indices of rows to be selected</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        static public void SelectIndices(int[] indices, ref DataGridView dataGridView) {
            if (dataGridView.MultiSelect) {
                for (int i = 0; i < dataGridView.RowCount; i++) {
                    if (indices.Contains(i)) {
                        dataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }


        /// <summary>
        /// Set an array of the row indices to be selected. Others not specified will be deselected. Works only when the target DataGridView is MultiSelect
        /// </summary>
        /// <param name="indices">The array of indices of rows to be selected</param>
        /// <param name="dataGridView">The target DataGridView object</param>
        static public void SetSelectedIndices(int[] indices, ref DataGridView dataGridView) {
            if (dataGridView.MultiSelect) {
                for (int i = 0; i < dataGridView.RowCount; i++) {
                    dataGridView.Rows[i].Selected = indices.Contains(i);
                }
            }
        }


    }
}

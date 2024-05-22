namespace WinFormsApp2.Extensions
{
    public static class DGVExtensions
    {
        public static IEnumerable<T> GetSelectedItems<T>(this DataGridView dgw)
        {
            foreach (DataGridViewRow item in dgw.SelectedRows)
            {
                var boxedItem = (T)item.DataBoundItem;
                yield return boxedItem;
            }
        }
    }
}

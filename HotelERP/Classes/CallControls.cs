namespace HotelERP
{
    public class CallControls
    {
        public void clear()
        {
            //clears any control added to the main panel
            if (MainForm.instance.MainPanel != null)
                while (MainForm.instance.MainPanel.Controls.Count > 0)
                    MainForm.instance.MainPanel.Controls.Remove(MainForm.instance.MainPanel.Controls[0]);
        }
    }
}

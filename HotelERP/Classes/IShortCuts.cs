namespace HotelERP
{
    public interface IShortCuts
    {
        string CapitalizeAll(string s);
        string CapitalizeFirst(string s);
        string CapitalizeFirstForEachWord(string s);
        void showErrorMessage(string message);
        void showInfoMessage(string message);
        void showMessage(string message);
        void showWarningMessage(string message);
    }
}
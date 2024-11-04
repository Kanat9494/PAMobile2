namespace PAMobile.Constants;

internal class PAConstants
{
    //расскомментировать для телефона на работе
    //internal const string SERVER_ROOT_URL = "http://localhost:45455";

    //работает для эмулятора
    //internal const string SERVER_ROOT_URL = "http://192.168.2.33:45457/";

    //боевой сервис
    //internal const string SERVER_ROOT_URL = "http://192.168.2.11:91/";
    internal const string SERVER_ROOT_URL = "https://mobile.salymfinance.kg/";
    internal static HttpClient MSHC = new HttpClient();

    //для дома
    //internal const string SERVER_ROOT_URL = "http://192.168.1.51:45455";

    internal const string CONFIRM_MESSAGE = "Kana-LetoCoOwner";

    internal const string REJECT_MESSAGE = "RejectingTheMessage!";

    //для работы
    internal const string FILE_BASE_PATH = "http://192.168.2.33:40";

    //для дома
    //internal const string FILE_BASE_PATH = "http://192.168.1.51:80";
    internal const string ACCESS_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyTmFtZSI6IjIyNDA5MTk5NDAxODgwIiwiU2lnbmVkVXBEYXRlIjoiMjMuMTAuMjAyNCAxNToxODo1MiIsIkNsaWVudENvZGUiOiI1MTE5NyIsIlVzZXJMb2dpbiI6IjIyNDA5MTk5NDAxODgwIiwiVXNlckZ1bGxOYW1lIjoi0JrRg9C00LDQudCx0LXRgNCz0LXQvdC-0LIg0JrQsNC90LDRgiDQmtGD0LTQsNC50LHQtdGA0LPQtdC90L7QstC40YciLCJVc2VyUGhvbmVOdW1iZXIiOiI5OTY3MDgzNjIxNjYiLCJleHAiOjE3MzEwNTA1NjAsImlzcyI6Imh0dHA6MTkyLjE2OC4yLjMzIiwiYXVkIjoiaHR0cDoxOTIuMTY4LjIuMzMifQ.78MCC6abCm99PWGqMPiRMc60xzPAE-uxEUHuiuiE42g";
}

public class PhoneList
{
    public string HomePhone;
    public string BusinessPhone;
    public string CellPhone;

    public PhoneList(string home, string business, string cell)
    {
        HomePhone = home;
        BusinessPhone = business;
        CellPhone = cell;
    }
}

public class Cards
{
    public string Name;
    public string Occupation;
    public int Age;
    public PhoneList Phone;    // 參考 PhoneList 類別
    public string Email;

    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    public string GetCard()
    {
        return $"姓名：{Name}\n" +
               $"職業：{Occupation}\n" +
               $"年齡：{Age}\n" +
               $"在家電話：{Phone.HomePhone}\n" +
               $"公司電話：{Phone.BusinessPhone}\n" +
               $"手機：{Phone.CellPhone}\n" +
               $"電子郵件：{Email}";
    }
}

namespace UI //IFactory interface will have one method.
{
    public interface IFactory //Creating this interface will help get a good layout for the class being implemented. 
    {
        //IMenu will produce a lot of Menues. 
        IMenu GetMenu(MenuType p_menu); //Needs a parameter of what I want and what MenuType I need.  
    }
}
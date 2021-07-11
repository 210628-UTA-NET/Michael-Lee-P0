namespace UI //IFactory interface will have one method.
{
    public interface IFactory
    {
        //IMenu will produce a lot of Menues. 
        IMenu GetMenu(MenuType p_menu); //Needs a parameter of what I want and what MenuType I need.  
    
    }
}
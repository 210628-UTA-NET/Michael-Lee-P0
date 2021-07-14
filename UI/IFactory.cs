namespace UI //IFactory interface will have one method.
{
    public interface IFactory //Creating this interface will have a good layout for the class implemented. 
    {
        //IMenu will produce a lot of Menues. 
        IMenu GetMenu(MenuType p_menu); //Parameter of what MenuType I need.  
    }
}
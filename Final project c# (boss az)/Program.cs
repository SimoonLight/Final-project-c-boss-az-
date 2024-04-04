

using Final_project_c___boss_az_.Desing;
using Final_project_c___boss_az_.Backend;
using Final_project_c___boss_az_.Database;
using Final_project_c___boss_az_.File_;

while (true)
{
    File_class.ReadWorkersFromJson();
    File_class.ReadEmployersFromJson();
    
    int users_first_chice=Control_options.move_options(Options_Class.first_menu_options, Options_Class.first_menu_options_count, 1);
    if (users_first_chice == 0)
    {
        Start_class.Start_page();
    }
    else if (users_first_chice == 1)
    {
        About_class.Show_about();
        Console.WriteLine("\n\n\n Enter any button for contunie ");
        string nothing =Console.ReadLine();
    }
    else if (users_first_chice == 2)
    {
        Settings_class.Show_Settings();
    }
    else
    {
        Console.Clear();
        string remember_color_ = All_settings.foreground_Color;
        All_settings.select_desing_color(All_settings.desing_Color);
        Desings_Class.exit_desing();
        All_settings.select_color_foreground(remember_color_);
        break;
    }
}


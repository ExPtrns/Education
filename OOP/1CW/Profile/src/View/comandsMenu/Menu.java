package View.comandsMenu;

import View.ConsoleUI;

public abstract class Menu {
    private String description;
    private ConsoleUI consoleUI;

    public Menu(String description, ConsoleUI consoleUI) {
        this.consoleUI = consoleUI;
        this.description = description;
    }
    ConsoleUI getConsoleUI() {
        return consoleUI;
    }
    public String getDescription() {
        return description;
    }
    public abstract void action();

}
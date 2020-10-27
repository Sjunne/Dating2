package Tier3.DAOProfile;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class PersonalLogin {
    private static final PersonalLogin personalLogin = new PersonalLogin();
    private static String DBCONNECT = "jdbc:postgresql://localhost/postgres?currentSchema=datingdatabase";
    private static String DBUSERNAME = "postgres";
    private static String DBPASSWORD = "1234";

    public void PersonalLogin() {
        try {
            DriverManager.registerDriver(new org.postgresql.Driver());
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static String getDBCONNECT() {
        return DBCONNECT;
    }

    public static String getDBPASSWORD() {
        return DBPASSWORD;
    }

    public static String getDBUSERNAME() {
        return DBUSERNAME;
    }

    public static Connection getConnection()
    {
        try {
            return DriverManager.getConnection(
                    PersonalLogin.getDBCONNECT(), PersonalLogin.getDBUSERNAME(), PersonalLogin.getDBPASSWORD());
        } catch (SQLException e) {
            e.printStackTrace();
            return null;
        }
    }
}

package Tier3.DAOProfile;

import Tier3.Data.ProfileData;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class DAOProfileImpl implements DAOProfile {

    @Override
    public void editProfile(ProfileData profileData) {
        try {
            try(Connection connection = PersonalLogin.getConnection())
            {
                PreparedStatement statement = connection.prepareStatement("update Profile set information=? where username=?");
                statement.setString (1, profileData.getIntro());
                statement.setString(2, profileData.getUsername());
                statement.executeUpdate();
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}

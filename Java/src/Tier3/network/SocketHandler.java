package Tier3.network;

import Tier3.DAOProfile.DAOProfile;
import Tier3.DAOProfile.DAOProfileImpl;
import Tier3.Data.ProfileData;
import Tier3.Data.Request;
import com.google.gson.Gson;

import java.io.IOException;
import java.io.InputStream;
import java.net.Socket;

public class SocketHandler implements Network, Runnable
{
    private InputStream inputStream;
    private Gson gson;
    private DAOProfile daoProfile;

    public SocketHandler(Socket socket) throws IOException {
       inputStream = socket.getInputStream();
       gson = new Gson();
       daoProfile = new DAOProfileImpl();
    }

    @Override
    public void run() {
        while (true) {
            System.out.println("Er inde i while true SH");
            byte[] lenbytes = new byte[1024];
            try {
                int read = inputStream.read(lenbytes,0,lenbytes.length);
                String message = new String(lenbytes,0,read);
                System.out.println(message);
                Request request = gson.fromJson(message, Request.class);
                System.out.println(request.getO());


                switch (request.getRequestOperation())
                {
                    case EDITINTRODUCTION:
                    {
                        ProfileData profileData = CreateProfileData(request.getO().toString());
                        daoProfile.editProfile(profileData);
                    }
                }


            } catch (IOException e) {
                e.printStackTrace();
            }
        }

    }

    public ProfileData CreateProfileData(String test)
    {
        String[] test1 = test.split(",");

        String[] test2 = test1[0].split("=");

        ProfileData profileData = new ProfileData();
        profileData.setIntro(test2[1]);

        String [] test3 = test1[1].split("=");

        String[] test4 = test3[1].split("}");

        profileData.setUsername(test4[0]);

       return profileData;
    }
}

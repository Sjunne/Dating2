package Tier3.network;

import Tier3.Data.ProfileData;
import Tier3.Data.Request;

import java.io.IOException;
import java.io.InputStream;
import java.net.Socket;

public class SocketHandler implements Network, Runnable
{
    private InputStream inputStream;
    private Gson gson;

    public SocketHandler(Socket socket) throws IOException {
       inputStream = socket.getInputStream();
       gson = new Gson();
    }

    @Override
    public void run() {
        byte[] lenbytes = new byte[1024];
        try {
            int read = inputStream.read(lenbytes,0,lenbytes.length);
            String message = new String(lenbytes,0,read);

            Request request = gson.fromJson(message, Request.class);



        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

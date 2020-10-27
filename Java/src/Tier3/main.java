package Tier3;

import Tier3.network.SocketHandler;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class main
{
  public static void main(String[] args) throws IOException {
    ServerSocket welcomeSocket = new ServerSocket(6000);


    while(true)
    {
      Socket accept = welcomeSocket.accept();
      System.out.println("New Client Accepted");

      SocketHandler target = new SocketHandler(accept);
      Thread one = new Thread(target);
      one.start();
      System.out.println("Thread Started");
    }
  }
}

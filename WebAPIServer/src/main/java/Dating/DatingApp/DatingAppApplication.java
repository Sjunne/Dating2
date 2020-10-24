package Dating.DatingApp;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@SpringBootApplication
public class DatingAppApplication {

	public static void main(String[] args) {
		SpringApplication.run(DatingAppApplication.class, args);
	}


		@GetMapping("/Maria")
	public String getHelloMattias()
	{
		System.out.println("hey");
		return "Hello from Mattias";
	}

}

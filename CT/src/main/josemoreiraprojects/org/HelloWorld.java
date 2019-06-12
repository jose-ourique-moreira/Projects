package josemoreiraprojects.org;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

public class HelloWorld extends HttpServlet {

    public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException , IOException {
        PrintWriter htmlWriter = response.getWriter();

        htmlWriter.println("<html>");
        htmlWriter.println("<head>");
        htmlWriter.println("<title> Hello World </title>");
        htmlWriter.println("</head>");
        htmlWriter.println("<body>");
        htmlWriter.println("Hello World");
        htmlWriter.println("</body>");
        htmlWriter.println("</html>");
    }


}

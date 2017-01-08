package org.fmi.tryme;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/")
public class HtmlStaticFilesController {

	@RequestMapping(name="/home", method=RequestMethod.GET)
	public String goHome() {
		return "Home";
	}
	
}

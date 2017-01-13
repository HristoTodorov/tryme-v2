package org.fmi.tryme;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/test")
public class TestController {

	@RequestMapping(method=RequestMethod.GET)
	public String makeTest() {
		return "beginTest";
	}
}

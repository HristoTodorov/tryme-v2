package org.fmi.tryme;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/categories")
public class CategoriesController {

	@RequestMapping(method=RequestMethod.GET)
	public String categoriesUrl() {
		return "categories";
	}
}

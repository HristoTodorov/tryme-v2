package org.fmi.tryme;

import javax.ws.rs.PathParam;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/templates")
public class CssFilesController {

	@RequestMapping(name="/css/{cssFile}", method=RequestMethod.GET)
	public String cssStaticResourceProvider(@PathParam("cssFile") String cssFile) {
		return cssFile;
	}

}

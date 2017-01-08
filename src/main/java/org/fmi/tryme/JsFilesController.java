package org.fmi.tryme;

import javax.ws.rs.PathParam;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/templates/js")
public class JsFilesController {
	@RequestMapping(name="/{jsFile}", method=RequestMethod.GET)
	public String jsStaticResourceProvider(@PathParam("jsFile") String jsFile) {
		return jsFile;
	}
}

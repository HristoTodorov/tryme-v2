package org.fmi.tryme;

import javax.ws.rs.PathParam;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/templates/lib")
public class JsLibFilesController {

	@RequestMapping(name="/{jsLibFile}", method=RequestMethod.GET)
	public String jsLibFileProvider(@PathParam("jsLibFile") String jsLibFile) {
		return jsLibFile;
	}
}

package org.fmi.tryme;

import javax.ws.rs.PathParam;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/templates/imgs")
public class ImagesFilesController {

	@RequestMapping(name="/{imgFile}", method=RequestMethod.GET)
	public String imgResourceProvider(@PathParam("imgFile") String imgFile) {
		return imgFile;
	}
}

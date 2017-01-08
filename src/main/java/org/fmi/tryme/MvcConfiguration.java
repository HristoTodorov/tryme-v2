package org.fmi.tryme;

import java.util.HashSet;
import java.util.Set;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurerAdapter;
import org.thymeleaf.extras.tiles2.dialect.TilesDialect;
import org.thymeleaf.spring4.SpringTemplateEngine;
import org.thymeleaf.templateresolver.ClassLoaderTemplateResolver;
import org.thymeleaf.templateresolver.ITemplateResolver;

@Configuration
public class MvcConfiguration extends WebMvcConfigurerAdapter {

    @Bean
    public ClassLoaderTemplateResolver cssResolver() {
    	ClassLoaderTemplateResolver resolver = new ClassLoaderTemplateResolver();
    	resolver.setCacheable(true);
    	resolver.setOrder(1);
    	resolver.setPrefix("/templates/css/");
    	return resolver;
    }
	
    @Bean
    public ClassLoaderTemplateResolver htmlResolver() {
    	ClassLoaderTemplateResolver result = new ClassLoaderTemplateResolver();
        result.setPrefix("/templates/htmls/");
        result.setSuffix(".html");
        result.setTemplateMode("HTML5");
        result.setOrder(0);
        result.setCacheable(true);
        return result;
    }
    
    @Bean
    public ClassLoaderTemplateResolver jsLibResolver() {
    	ClassLoaderTemplateResolver resolver = new ClassLoaderTemplateResolver();
    	resolver.setCacheable(true);
    	resolver.setOrder(3);
    	resolver.setPrefix("/templates/lib/");
    	return resolver;
    }
    
    @Bean
    public ClassLoaderTemplateResolver jsResolver() {
    	ClassLoaderTemplateResolver resolver = new ClassLoaderTemplateResolver();
    	resolver.setCacheable(true);
    	resolver.setOrder(2);
    	resolver.setPrefix("/templates/js/");
    	return resolver;
    }
    
    @Bean
    public ClassLoaderTemplateResolver imgResolver() {
    	ClassLoaderTemplateResolver resolver = new ClassLoaderTemplateResolver();
    	resolver.setCacheable(true);
    	resolver.setOrder(4);
    	resolver.setPrefix("/templates/imgs/");
    	return resolver;
    }
    
	@Override
    public void addResourceHandlers(ResourceHandlerRegistry registry) {
        registry.addResourceHandler("/**").addResourceLocations("/", "classpath:/templates/").setCachePeriod(31556926);
    }
    
    @Bean
    public SpringTemplateEngine templateEngine() {
        SpringTemplateEngine templateEngine = new SpringTemplateEngine();
        Set<ITemplateResolver> templateResolvers = new HashSet<>();
        templateResolvers.add(cssResolver());
        templateResolvers.add(htmlResolver());
        templateResolvers.add(jsLibResolver());
        templateResolvers.add(jsResolver());
        templateResolvers.add(imgResolver());
        templateEngine.setTemplateResolvers(templateResolvers);
        templateEngine.addDialect(new TilesDialect());
        return templateEngine;
    }

}

package com.example.clientsboot.endpoint;

import org.springframework.stereotype.Component;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import com.example.clientsboot.service.banqueWS;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;
import ws.Compte;
import ws.ConvertResponse;
import java.util.List;

@Component
@Endpoint
public class banque_endpoint {
    private static final String NAMESPACE_URI = "http://ws/";
    private  banqueWS banqueService;

    public double conversion(double mt){
        return banqueService.conversion(mt);
    }


    public Compte getCompte(int code){
        return banqueService.getCompte(code);
    }

    public List<Compte> listComptes(){
        return banqueService.listComptes();
    }
    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "ConvertResponse")
    @ResponsePayload
    public ConvertResponse handleConvertResponse(@RequestPayload ConvertResponse request) {
        // handle ConvertResponse message here
        ConvertResponse response = new ConvertResponse();
        response.setReturn(conversion(request.getReturn()));
        return response;
    }

}


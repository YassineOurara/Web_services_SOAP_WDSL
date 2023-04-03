package com.example.clientsboot.service;
import org.springframework.stereotype.Service;
import ws.Compte;

import java.util.List;

@Service
public class banqueWS {

    public double conversion(double mt) {
        return mt * 10.54;
    }

    public Compte getCompte(int code) {
        return new Compte(code, Math.random() * 9888);
    }


    public List<Compte> listComptes() {
        return List.of(
                new Compte(1, Math.random() * 9888),
                new Compte(2, Math.random() * 9888),
                new Compte(3, Math.random() * 9888)
        );
    }
}
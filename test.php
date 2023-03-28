<?php
$client = new SoapClient('http://localhost:8585/BanqueWS?wsdl');
$param=new stdClass();
$param->montant=23;
$res=$client->__soapCall("conversionEuroDH",array($param));
//var_dump($res);
echo($res->return);
$param2=new stdClass();
$param2->arg0=2;
$res2=$client->__soapCall("getCompte",array($param2));
//var_dump($res2);
echo("Code=".$res2->return->code);
echo("<br/>Solde=".$res2->return->solde);
$res3=$client->__soapCall("getComptes",array());
//var_dump($res3);
echo ("<hr/>");
foreach($res3->return as $cpte){
echo("Code=".$cpte->code);
echo("<br/>Solde=".$cpte->solde);
echo("<br/>");
}
?>
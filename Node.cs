/**
Node  */

namespace MEMS{

    class Node{
        public string status; // on off
        public string powerDirection;
        public float  powerValue;
        public int port; 
        public string commProtocol;
        public string name;

        // Method
        public Node(string name,string protocol,int port){
            this.name=name;
            this.commProtocol=protocol;
            this.port=port;
        }
        public void CutOFF(){
            // 
        }

        public void Start(){

        }

        public string Get(){
            return "";
        }
    }

    class Inv :Node{
        //继承基类
        public Inv(string name,string protocol,int port):base( name, protocol, port){

        }
        public new string   Get(){
            return "THis is INV";
        }
        public void SetPowerValue(){

        }
    }

    class Load:Node{
        public Load(string name,string protocol,int port):base( name, protocol, port){

        }
        public new string Get(){
            return "THis is LOAD";
        }
    }
}

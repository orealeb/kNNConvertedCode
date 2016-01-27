// Conversion output is limited to 2048 chars
// Share Varycode on Facebook and tweet on Twitter
// to double the limits.

using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;

class Instance{
    
	public string instanceClass; //The original class of the instance as read from file.
	public string classifiedClass; //This is only for testData entries. This stores the value of the class which we assign it during testing.

	public IDictionary<int?,double?> parameters = new LinkedHashMap<int?,double?>();
	/* Stores the min and max value of any particular dimension */
	public static IDictionary<int?,double?> minTRN = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> minTST = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> maxTRN = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> maxTST = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> meanTRN = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> stdDevTRN = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> meanTST = new Hashtable<int?,double?>();
	public static IDictionary<int?,double?> stdDevTST = new Hashtable<int?,double?>();

	public Instance(string instanceClass){
		this.instanceClass = instanceClass;
	}

	public void addTerm(int index, double value, int type){
		parameters.put(index,value);

		if(type == 0){

			if(meanTRN.containsKey(index)){
				meanTRN.put(index,(meanTRN.get(index)+value));
			}else{
				meanTRN.put(index,value);
			}

			if(maxTRN.containsKey(index)){
				if(maxTRN.get(index)<value){
					maxTRN.put(index,value);
				}
			}else{
				maxTRN.put(index,value);
			}

			if(minTRN.containsKey(index)){
				if(minTRN.get(index)>value){
					minTRN.put(index,value);
				}
			}else{
				minTRN.put(index,value);
			}
		}else if(type == 1){

			if(meanTST.containsKey(index)){
				meanTST.put(index,(meanTST.get(index)+value));
			}else{
				meanTST.put(index,value);
			}

			if(maxTST.containsKey(index)){
			maxTST.put/* [8,16] expecting: identifier: (*/index,value/* [8,63] expecting: ';', ',': )*/;
				}
			/* [10,4] expecting: EOF: }*//* [10,33] expecting: EOF: else*//* [10,66] expecting: EOF: {*/
				/* [11,5] expecting: EOF: maxTST*//* [11,39] expecting: EOF: .*//* [11,69] expecting: EOF: put*//* [11,101] expecting: EOF: (*//* [11,132] expecting: EOF: index*//* [11,167] expecting: EOF: ,*//* [11,198] expecting: EOF: value*//* [11,233] expecting: EOF: )*/;
			/* [12,4] expecting: EOF: }*/

			/* [14,4] expecting: EOF: if*//* [14,34] expecting: EOF: (*//* [14,64] expecting: EOF: minTST*//* [14,99] expecting: EOF: .*//* [14,129] expecting: EOF: containsKey*//* [14,170] expecting: EOF: (*/index)){
				if(minTST.get(index)>value){
					minTST.put(index,value);
				}
			}else{
				minTST.put(index,value);
			}
		}
	}

}

class Distances implements Comparable<Distances>{
	double distanceValue;
	int fromInstance;

	public Distances(){
		this.distanceValue = 0;
		this.fromInstance = 0;
	}

	public int compareTo(Distances o){
		if ((this.distanceValue - o.distanceValue)>0)
			return 1;
		else if ((this.distanceValue - o.distanceValue)==0)
			return 0;
		else return -1;
	}
}

class Similarities implements Comparable<Similarities>{
	double similarityValue;
	int fromInstance;

	public Similarities(){
		this.similarityValue = 0;
		this.fromInstance = 0;
	}

	public int compareTo(Similarities o){
		if((this.similarityValue - o.similarityValue)>0)
			return -1;
		else if ((this.similarityValue - o.similarityValue) == 0)
			return 0;
		else return 1;
	}

}

class Similarities implements Comparable<Similarities>{
	double similarityValue;
	int fromInstance;

	public Similarities(){
		this.similarityValue = 0;
		this.fromInstance = 0;
	}

	public int compareTo(Similarities o){
		if((this.similarityValue - o.similarityValue)>0)
			return -1;
		else if ((this.similarityValue - o.similarityValue) == 0)
			return 0;
		else return 1;
	}

}/* [26,2] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': *//* [26,298] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': *//* [26,596] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': *//* [26,894] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': *//* [26,1192] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{'

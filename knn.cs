
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

public class Main {
    public  ArrayList<Candidate> trainingCadidateList;

	public  ArrayList<Candidate> testCadidateList;

	public  ArrayList<Candidate> finalTestCadidateList;


	public Main(string trainFile, string testFile, int k){
		// train
				BufferedReader trainingDataSet = readDataFile(trainFile);
				trainingCadidateList = loadCandidateList(trainingDataSet);
				// test
				BufferedReader testDataSet = readDataFile(testFile);
				testCadidateList = loadCandidateList(testDataSet);
				finalTestCadidateList = new ArrayList<Candidate>();


				kNearestNighbour(trainingCadidateList, testCadidateList, k);
				double count = 0;
				double matched = 0;
				for(Candidate testC : testCadidateList){
					string stringC = testC.toString();
					string finalCan = finalTestCadidateList.get((int)count).ToString();
					if(testC.getIntClass() == finalTestCadidateList.get((int)count).getIntClass()){
						matched++;
						Console.WriteLine(stringC+" "+finalCan+ " MATCHED");
					}else{
						Console.WriteLine(stringC+" "+finalCan+ " UNMATCHED");
					}
					count++;

				}
				Console.Write(matched+"/"+count);
				Console.Write(" %.2f",matched/count*100);
				Console.Write("%");


	}
	public BufferedReader readDataFile(string filename) {
		BufferedReader inputReader = null;

		try {
			inputReader = new BufferedReader(new FileReader(filename));
		} catch (FileNotFoundException ex) {
			Console.Error.WriteLine("File not found: " + filename);
		}

		return inputReader;
	}



	public ArrayList<Candidate> loadCandidateList(BufferedReader dataFile) {
		ArrayList<Candidate> toReturn = new ArrayList<Candidate>();
		try {
			string line = dataFile.readLine();
			Scanner scanLine;
			ArrayList<double?> featureVectorToAdd;
			while (line != null && !(line.equals(""))) {
				scanLine = new Scanner(line);
				featureVectorToAdd = new ArrayList<double?>();
				int intClass = -1
				featureVectorToAdd.add/* [13,27] expecting: identifier: (*/scanLine/* [13,72] expecting: ';', ',': .*//* [13,107] expecting: ';', ',': nextDouble*/()/* [13,154] expecting: '{', ';': )*/;
				featureVectorToAdd.add/* [14,27] expecting: identifier: (*/scanLine/* [14,72] expecting: ';', ',': .*//* [14,107] expecting: ';', ',': nextDouble*/()/* [14,154] expecting: '{', ';': )*/;
				featureVectorToAdd.add/* [15,27] expecting: identifier: (*/scanLine/* [15,72] expecting: ';', ',': .*//* [15,107] expecting: ';', ',': nextDouble*/()/* [15,154] expecting: '{', ';': )*/;
				featureVectorToAdd.add/* [16,27] expecting: identifier: (*/scanLine/* [16,72] expecting: ';', ',': .*//* [16,107] expecting: ';', ',': nextDouble*/()/* [16,154] expecting: '{', ';': )*/;

				String typeOfPlant = scanLine.next();
				/* [19,5] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': if*/ /* [19,304] expecting: 'abstract', 'boolean', 'byte', 'char', 'class', 'double', 'enum', 'final', 'float', 'int', 'interface', 'long', 'native', 'private', 'protected', 'public', 'short', 'static', 'strictfp', 'synchronized', 'transient', 'void', 'volatile', identifier, '{', '}', ';', '<', '@': (*/typeOfPlant.equals/* [19,621] expecting: identifier: (*//* [19,659] expecting: identifier: "Iris-setosa"*/)) {
					intClass = 1;
				} else if (typeOfPlant.equals("Iris-versicolor")) {
					intClass = 2;
				} else if (typeOfPlant.equals("Iris-virginica")) {
					intClass = 3;
					}
						Candidate c = new Candidate(featureVectorToAdd, intClass);
				toReturn.add/* [15,17] expecting: identifier: (*/c/* [15,55] expecting: ';', ',': )*/;
				line /* [16,10] expecting: identifier: =*/ dataFile/* [16,56] expecting: ';', ',': .*//* [16,91] expecting: ';', ',': readLine*/();
				scanLine.close/* [17,19] expecting: identifier: (*//* [17,56] expecting: identifier: )*//* [17,93] expecting: identifier: ;*/

			/* [19,4] expecting: identifier: }*/
			/* [20,4] expecting: identifier: return*/ toReturn;

		} /* [22,5] expecting: EOF: catch*/ /* [22,39] expecting: EOF: (*//* [22,69] expecting: EOF: IOException*/ /* [22,110] expecting: EOF: e*//* [22,141] expecting: EOF: )*/ /* [22,173] expecting: EOF: {*/
			// TODO Auto-generated catch block
			/* [24,4] expecting: EOF: e*//* [24,33] expecting: EOF: .*//* [24,63] expecting: EOF: printStackTrace*//* [24,107] expecting: EOF: (*/);
		}
		return null;

	}

	public static void main(String[] args) {
		if(args.length == 2){
			Scanner in = new Scanner(System.in);
			System.out.printf("Enter k Value:  ");
		      int k = in.nextInt();
			new Main(args[0],args[1],k);
		}

	}

	public void kNearestNighbour(ArrayList<Candidate> trainList,
			ArrayList<Candidate> testList, int k) {

		for(Candidate testC : testList){
			HashMap<Double,Candidate> hashDoubleToCandidate = new HashMap<Double,Candidate>();
			double keys[] = new double[k+1];
			int count = 0;

			for(Candidate trainC : trainList){
				double distance = euclidianDistance(testC, trainC);
				hashDoubleToCandidate.put(distance, trainC);
				keys[k] = Double.MAX_VALUE;
				if(count < k){
					keys[count] = distance;
			
						count/* [14,11] expecting: identifier: ++*//* [14,49] expecting: identifier: ;*/
					//Arrays.sort(keys);
				/* [16,5] expecting: identifier: }*/
				/* [17,5] expecting: identifier: else*/ /* [17,45] expecting: identifier: {*/
					keys[/* [18,11] expecting: ']': k*/] = distance;
					Arrays.sort/* [19,17] expecting: identifier: (*/keys/* [19,58] expecting: ';', ',': )*/;
				}
			/* [21,4] expecting: EOF: }*/

			/* [23,4] expecting: EOF: int*/ /* [23,36] expecting: EOF: class1*/ /* [23,72] expecting: EOF: =*/ /* [23,103] expecting: EOF: 0*/;
			/* [24,4] expecting: EOF: int*/ /* [24,36] expecting: EOF: class2*/ /* [24,72] expecting: EOF: =*//* [24,102] expecting: EOF: 0*/;
			/* [25,4] expecting: EOF: int*/ /* [25,36] expecting: EOF: class3*//* [25,71] expecting: EOF: =*/0;
			for(int i = 0; i <= k - 1; i++){
				Candidate c = hashDoubleToCandidate.get(keys[i]);
				if(c.getIntClass() == 1){class1++;}
				if(c.getIntClass() == 2){class2+=2;}
				if(c.getIntClass() == 3){class3+=3;}
			}
			double result = (class1+class2+class3)/k;
			int finalclass = (int) result;
			Candidate c = new Candidate();
			c.setFeatureVector(testC.getFeatureVector());
			c.setIntClass(finalclass);
			finalTestCadidateList.add(c);


		}

	}

	public double euclidianDistance(Candidate test_candidate,
			Candidate trianing_candidate) {
		double result = 0;
		
		result /* [13,10] expecting: identifier: +=*/ (Math.pow/* [13,58] expecting: identifier, '...': (*/test_candidate/* [13,116] expecting: ')': .*//* [13,147] expecting: ')': getFeatureVector*//* [13,193] expecting: ')': (*/)/* [13,225] expecting: 'throws', '{': .*//* [13,266] expecting: 'throws', '{': get*//* [13,309] expecting: 'throws', '{': (*//* [13,350] expecting: 'throws', '{': 0*//* [13,391] expecting: 'throws', '{': )*/
				/* [14,5] expecting: 'throws', '{': -*/ /* [14,45] expecting: 'throws', '{': trianing_candidate*//* [14,102] expecting: 'throws', '{': .*//* [14,143] expecting: 'throws', '{': getFeatureVector*//* [14,199] expecting: 'throws', '{': (*//* [14,240] expecting: 'throws', '{': )*//* [14,281] expecting: 'throws', '{': .*//* [14,322] expecting: 'throws', '{': get*//* [14,365] expecting: 'throws', '{': (*//* [14,406] expecting: 'throws', '{': 0*/), 2));///(Math.pow(max0-min0, 2));
		result += (Math.pow(test_candidate.getFeatureVector().get(1)
				- trianing_candidate.getFeatureVector().get(1), 2));///(Math.pow(max1-min1, 2));
		result += (Math.pow(test_candidate.getFeatureVector().get(2)
				- trianing_candidate.getFeatureVector().get(2), 2));///(Math.pow(max2-min2, 2));
		result += (Math.pow(test_candidate.getFeatureVector().get(3)
				- trianing_candidate.getFeatureVector().get(3), 2));///(Math.pow(max3-min3, 2));
		result = Math.sqrt(result);
		return result;

	}


}

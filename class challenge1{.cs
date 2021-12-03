class challenge1{
    static int checkLarger(int[] sonarList){
        int total=0;
        for(int i=1;i<sonarList.length;i++){
            if(sonarList[i]>sonarList[i-1]){
                total++;
            }
        }
        return total;
    }
    public static void main(String[] args){
        int[] sonarInput = {100,125,124,127,141,145,160};
        Console.WriteLine(checkLarger(Arrays.toString(sonarInput));
    }
}
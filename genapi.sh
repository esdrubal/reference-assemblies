
BASEDIR=$(dirname $0)
APIDIR=$BASEDIR/api-cs-files

mkdir -p $APIDIR

GENAPI=$BASEDIR/genapi.exe

for framework_dir in $BASEDIR/v*; do
   if [ -d $framework_dir ]; then
       FRAMEWORK=$(basename $framework_dir)
       OUTDIR=$APIDIR/$FRAMEWORK
       echo "Generating framework $FRAMEWORK api files";
       mkdir -p $OUTDIR
       for assembly_path in $framework_dir/*.dll; do
           ASSEMBLY=$(basename $assembly_path)
           OUTFILE=$OUTDIR/$ASSEMBLY.cs
           echo "   $ASSEMBLY"
           mono $GENAPI $assembly_path -libPath $framework_dir > $OUTFILE
       done
   fi
done

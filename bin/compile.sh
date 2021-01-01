#!/bin/bash

if [ -L $0 ]
then
    BASE_DIR=`dirname $(readlink $0)`
else
    BASE_DIR=`dirname $0`
fi
base_path=$(cd $BASE_DIR/..; pwd)

cd $base_path && \
  protoc -I ./proto \
  --go_out=dist/go \
  --python_out=dist/python \
  --js_out=dist/js \
  --java_out=dist/java \
  --csharp_out=dist/csharp \
  --php_out=dist/php \
  --ruby_out=dist/ruby \
  ./proto/*.proto

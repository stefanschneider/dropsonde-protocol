#!/bin/bash

dir_resolve()
{
cd "$1" 2>/dev/null || return $?  # cd to desired directory; if fail, quell any error messages but return exit status
echo "`pwd -P`" # output full, link-resolved path
}

set -e

TARGET=`dir_resolve $1`
if [ -z "$TARGET" ]; then
    echo 'USAGE: `generate-java.sh TARGET_PATH`'
    echo ''
    echo 'TARGET_PATH is where you would like the control and events packages to be generated.'
    exit 1
fi

pushd events
mkdir -p $TARGET/Events
protoc -I=. --csharp_out=$TARGET/Events *.proto
popd

pushd control
mkdir -p $TARGET/Control
protoc -I=. --csharp_out=$TARGET/Control *.proto
popd

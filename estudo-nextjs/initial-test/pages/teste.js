import { NextLink } from "../src/components/Link"
import Head from "next/head"

export default function TestePage() {
    return (
        <div>
            <Head>
                <title>texto na barra</title>
            </Head>
            <p> teste</p>
            <NextLink href="/">  ir para home      </NextLink>

        </div>
    )
}